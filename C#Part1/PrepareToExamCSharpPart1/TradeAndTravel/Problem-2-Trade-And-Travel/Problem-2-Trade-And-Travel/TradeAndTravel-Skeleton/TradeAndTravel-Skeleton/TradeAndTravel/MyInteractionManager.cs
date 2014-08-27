using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class MyInteractionManager : InteractionManager
    {        
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {                
                case "gather":
                    this.HandleGatherInteraction(commandWords, actor);
                    break;
                case "craft":
                    this.HandleCraftInteraction(commandWords, actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        protected override void HandleItemCreation(string itemTypeString, string itemNameString, string itemLocationString)
        {
            var itemLocation = locationByName[itemLocationString];

            Item item = null;
            item = this.CreateItem(itemTypeString, itemNameString, itemLocation, item);

            this.ownerByItem[item] = null;
            strayItemsByLocation[itemLocation].Add(item);
        }

        protected void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            if (commandWords[2] == "armor")
            {
                foreach (var item in actor.ListInventory())
                {
                    if ((item as Iron) != null)
                    {
                        this.AddToPerson(actor, new Armor(commandWords[3]));
                        break;
                    }
                } 
            }
            else if (commandWords[2] == "weapon")
            {
                bool isIron = false;
                bool isWood = false;
                foreach (var item in actor.ListInventory())
                {
                    if ((item as Iron) != null)
                    {
                        isIron = true;
                    }
                    else if ((item as Wood) != null)
	                {
                        isWood = true;
	                }

                    if (isIron && isWood)
                    {
                        this.AddToPerson(actor, new Weapon(commandWords[3]));
                        break;
                    }
                } 
            }
        }

        protected void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            if (actor.Location.LocationType == LocationType.Forest)  
            {
                foreach (var item in actor.ListInventory())
                {
                    if ((item as Weapon) != null)
                    {
                        this.AddToPerson(actor, new Wood(commandWords[2], actor.Location));
                        break; 
                    }
                }
            }

            if (actor.Location.LocationType.Equals(LocationType.Mine)) 
            {
                foreach (var item in actor.ListInventory())
                {
                    if ((item as Armor) != null)
                    {
                        this.AddToPerson(actor, new Iron(commandWords[2], actor.Location));
                        break;
                    }
                }                
            }
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {                
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);  
                   
            }
            return item;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {                
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);  
                  
            }
            return person;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {                
                case "mine":
                    location = new MineLocation(locationName);
                    break;
                case "forest":
                    location = new ForestLocation(locationName);
                    break;
                default:
                    return base.CreateLocation(locationTypeString, locationName);                    
            }
            return location;
        }

        protected override void HandlePersonCreation(string personTypeString, string personNameString, string personLocationString)
        {
            base.HandlePersonCreation(personTypeString, personNameString, personLocationString);
        }
    }
}

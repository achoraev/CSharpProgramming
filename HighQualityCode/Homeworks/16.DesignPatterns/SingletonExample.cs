public sealed class Log
{
   	private static Log instance;
	private Log() {}
	public static Log Instance
   { 
      get
      {
         if (instance == null)
         {
            lock (instance)
            {
               if (instance == null)
                  instance = new Log();
            }
         }
         return instance;
      }
   }
}
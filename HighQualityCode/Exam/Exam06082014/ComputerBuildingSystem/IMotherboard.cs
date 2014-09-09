namespace ComputerBuildingSystem
{
    using System;

    /// <summary>
    /// Connect elements of motherboard - Ram, CPU, Hard drive, battery and video card.
    /// Elements used methods from interface to save and load to Ram and Draw on Video card.
    /// </summary>
    /// 
    public interface IMotherboard
    {
        /// <summary>
        /// This method draw on video card.
        /// </summary>
        /// <param name="data">Parameter data is a message that draw on video card.</param>
        void DrawOnVideoCard(string data);

        /// <summary>
        /// Load saved value of Ram memory from the computer.
        /// </summary>
        /// <returns>Value of Ram memory.</returns>
        int LoadRamValue();

        /// <summary>
        /// Save value of Ram memory to the computer.
        /// </summary>
        /// <param name="value">Value of Ram memory.</param>
        void SaveRamValue(int value);
    }
}
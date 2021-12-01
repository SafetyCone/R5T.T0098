using System;


namespace R5T.T0098
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Operation : IOperation
    {
        #region Static
        
        public static Operation Instance { get; } = new();

        #endregion
    }
}
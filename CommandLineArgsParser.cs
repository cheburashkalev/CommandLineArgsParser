using System;

namespace CommandLineArgsParser
{
    public static class CommandLineArgsParser
    {
        /// <summary>
        /// Getting the value of the argument that is specified in the format "arg_name = arg_value"
        /// </summary>
        /// <param name="key">Argument name</param>
        /// <param name="args">Arguments array</param>
        /// <returns>Argument value</returns>
        public static string GetValueByKey(string key , ref string[] args)
        {
            string value = String.Empty;
            foreach (var elem in args)
            {
                if (elem.IndexOf(key, StringComparison.Ordinal) != -1)
                {
                    value = elem.Split("=")[1];
                }  
            }
            return value;
        }
    }
}

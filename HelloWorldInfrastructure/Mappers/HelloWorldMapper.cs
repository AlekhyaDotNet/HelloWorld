﻿namespace HelloWorldInfrastructure.Mappers
{
    using HelloWorldInfrastructure.Models;

    /// <summary>
    ///     Mapper service for mapping types for the Hello World data service
    /// </summary>
    public class HelloWorldMapper : IHelloWorldMapper
    {
        /// <summary>
        ///     Maps a string to a TodaysData model
        /// </summary>
        /// <param name="input">The input</param>
        /// <returns>A TodaysData model</returns>
        public TodaysData StringToTodaysData(string input)
        {
            return new TodaysData { Data = input };
        }
    }
}
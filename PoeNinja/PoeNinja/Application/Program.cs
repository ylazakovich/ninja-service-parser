// <copyright file="Program.cs" company="YLazakovich">
// Copyright (c) YLazakovich. All rights reserved.
// </copyright>

namespace PoeNinja.Application
{
    using System;
    using Helper;
    using Items.Models;
    using Newtonsoft.Json;
    using RestSharp;
    using Utils;

    /// <summary>
    /// Makes run console application.
    /// </summary>
    public class Program : ApplicationHelper
    {
        public static void Main()
        {
            RestClient client;

            client = new RestClient
            {
                BaseHost = "poe.ninja",
                BaseUrl = new Uri(Constants.Url)
            };

            Vault vault = new Vault();
            vault.SetSkillVault(client);
            vault.SetJewelVault(client);

            // var response2 = responseWrapper.GetJewelsInfo();
            // JewelsVault jewels = JsonConvert.DeserializeObject<JewelsVault>(ConvertResponseToJson(response2));
            // TakeDataFromVault(skills);
        }
    }
}
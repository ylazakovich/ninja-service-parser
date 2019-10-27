// <copyright file="Vault.cs" company="YLazakovich">
// Copyright (c) YLazakovich. All rights reserved.
// </copyright>

namespace PoeNinja.Application.Utils
{
    using System.Collections.Generic;
    using Helper;
    using Items.Models;
    using Items.Vaults;
    using Newtonsoft.Json;
    using RestSharp;

    public class Vault : ApplicationHelper
    {
        public Dictionary<string, dynamic> Storage { get; private set; }

        private static Vault instance;

        public static Vault GetVaultInstance()
        {
            if (instance == null)
            {
                instance = new Vault();
                instance.Storage = new Dictionary<string, dynamic>();
            }

            return instance;
        }

        public void SetSkillVault(RestClient client)
        {
            ResponseWrapper responseWrapper = new ResponseWrapper(client);

            var response = responseWrapper.GetSkillInfo();

            SkillStorage storage = JsonConvert.DeserializeObject<SkillStorage>(ConvertResponseToJson(response));
            List<Gem> skills = storage.SkillGems;

            Storage[Constants.Gem] = skills;
        }

        public void SetJewelVault(RestClient client)
        {
            ResponseWrapper responseWrapper = new ResponseWrapper(client);

            var response = responseWrapper.GetJewelsInfo();

            JewelStorage storage = JsonConvert.DeserializeObject<JewelStorage>(ConvertResponseToJson(response));
            List<Jewel> jewels = storage.Jewels;

            Storage[Constants.Jewel] = jewels;
        }
    }
}
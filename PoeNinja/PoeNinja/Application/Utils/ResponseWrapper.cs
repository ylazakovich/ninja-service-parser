// <copyright file="ResponseWrapper.cs" company="YLazakovich">
// Copyright (c) YLazakovich. All rights reserved.
// </copyright>

namespace PoeNinja.Application.Utils
{
    using Helper;
    using RestSharp;

    /// <summary>
    /// Executes RestRequests.
    /// </summary>
    public class ResponseWrapper : ApplicationHelper
    {
        private RestClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWrapper"/> class.
        /// </summary>
        /// <param name="client">RestClient client.</param>
        public ResponseWrapper(RestClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Returns response about Skill Gems.
        /// </summary>
        /// <returns>RestResponse typo.</returns>
        public IRestResponse GetSkillsInfo()
        {
            RestRequest request = new RestRequest
            {
                Method = Method.GET,
                Parameters =
                {
                    new Parameter("league", Constants.League, ParameterType.QueryString),
                    new Parameter("type", Constants.Gem, ParameterType.QueryString),
                },
            };

            return client.Execute(request);
        }

        /// <summary>
        /// Returns response about Jewels.
        /// </summary>
        /// <returns>RestResponse.</returns>
        public IRestResponse GetJewelsInfo()
        {
            RestRequest request = new RestRequest
            {
                Method = Method.GET,
                Parameters =
                {
                    new Parameter("league", Constants.League, ParameterType.QueryString),
                    new Parameter("type", Constants.Jewel, ParameterType.QueryString),
                },
            };

            return client.Execute(request);
        }

        /// <summary>
        /// Returns response about Jewels.
        /// </summary>
        /// <returns>RestResponse.</returns>
        public IRestResponse GetWeaponsInfo()
        {
            RestRequest request = new RestRequest
            {
                Method = Method.GET,
                Parameters =
                {
                    new Parameter("league", Constants.League, ParameterType.QueryString),
                    new Parameter("type", Constants.Weapon, ParameterType.QueryString),
                },
            };

            return client.Execute(request);
        }
    }
}
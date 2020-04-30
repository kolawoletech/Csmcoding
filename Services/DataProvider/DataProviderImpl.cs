using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using sm_coding_challenge.Models;

namespace sm_coding_challenge.Services.DataProvider
{
    public class DataProviderImpl : IDataProvider
    {

        async Task<PlayerModel> IDataProvider.GetPlayerById(string id)
        {
            using (var client = new HttpClient())
            {
                
                var response = client.GetAsync("https://gist.githubusercontent.com/RichardD012/a81e0d1730555bc0d8856d1be980c803/raw/3fe73fafadf7e5b699f056e55396282ff45a124b/basic.json").Result;
                var stringData = response.Content.ReadAsStringAsync().Result;
                var dataResponse = JsonConvert.DeserializeObject<DataResponseModel>(stringData, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                foreach(var player in dataResponse.Rushing)
                {
                    if(player.Id.Equals(id))
                    {
                        return player;
                    }
                }
                foreach(var player in dataResponse.Passing)
                {
                    if(player.Id.Equals(id))
                    {
                        return player;
                    }
                }
                foreach(var player in dataResponse.Receiving)
                {
                    if(player.Id.Equals(id))
                    {
                        return player;
                    }
                }
                foreach(var player in dataResponse.Receiving)
                {
                    if(player.Id.Equals(id))
                    {
                        return player;
                    }
                }
                foreach(var player in dataResponse.Kicking)
                {
                    if(player.Id.Equals(id))
                    {
                        return player;
                    }
                }
            }
            return null;

        }

        async Task<LatestPlayerModel> IDataProvider.GetLatestPlayers(string id)
        {
            using (var client = new HttpClient())
            {
                
                var response = client.GetAsync("https://gist.githubusercontent.com/RichardD012/a81e0d1730555bc0d8856d1be980c803/raw/3fe73fafadf7e5b699f056e55396282ff45a124b/basic.json").Result;
                var stringData = response.Content.ReadAsStringAsync().Result;
                var dataResponse = JsonConvert.DeserializeObject<LatestPlayerDataResponseModel>(stringData, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });


                foreach(var player in dataResponse.Receiving)
                {
                    if(player.Id.Equals(id))
                    {
                        //return player;
                        return player;
                    }
                }
                foreach(var player in dataResponse.Rushing)
                {
                    if(player.Id.Equals(id))
                    {
                        return player;
                    }
                }

            }
            return null;
        }
    }
}

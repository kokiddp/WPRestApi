using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;
using RestSharp.Portable;

namespace WPRestApi
{
    class WPRestApi
    {
        private string Resource { get; set; }

        public WPRestApi(string Res)
        {
            Resource = Res;
        }

        /// <summary>
        /// Gets the WordPress page corresponding to the specified Slug
        /// </summary>
        public async Task<Page> GetPageBySlug(string slug)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/posts/",
                Method = Method.GET
            };
            request.AddParameter("slug", slug);

            return (JsonConvert.DeserializeObject<List<Page>>((await restClient.Execute(request)).Content)).First();
        }

        /// <summary>
        /// Gets the WordPress page corresponding to the specified Id
        /// </summary>
        public async Task<Page> GetPageById(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/posts/",
                Method = Method.GET
            };
            request.AddParameter("id", id.ToString());

            return (JsonConvert.DeserializeObject<List<Page>>((await restClient.Execute(request)).Content)).First();
        }

        /// <summary>
        /// Gets the WordPress post corresponding to the specified Id
        /// </summary>
        public async Task<Post> GetPostById(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/posts/" + id.ToString(),
                Method = Method.GET
            };

            return (JsonConvert.DeserializeObject<List<Post>>((await restClient.Execute(request)).Content)).First();
        }

        /// <summary>
        /// Gets the Media associated to the post corresponding to the specified Id
        /// </summary>
        public async Task<List<Media>> GetMediaFromPost(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/media?parent=" + id.ToString(),
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<List<Media>>((await restClient.Execute(request)).Content);
        }

        /// <summary>
        /// Gets all the post categories
        /// </summary>
        public async Task<List<Category>> GetAllCategories()
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/categories?per_page=99",
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<List<Category>>((await restClient.Execute(request)).Content);
        }
    }
}

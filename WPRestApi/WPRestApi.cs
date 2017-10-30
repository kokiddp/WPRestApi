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

        #region Posts

        /// <summary>
        /// Gets all the WordPress posts
        /// </summary>
        public async Task<List<Post>> GetAllPosts()
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/posts?per_page=100",
                Method = Method.GET
            };

            return (JsonConvert.DeserializeObject<List<Post>>((await restClient.Execute(request)).Content));
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
        /// Gets the password protected WordPress post corresponding to the specified Id
        /// </summary>
        public async Task<Post> GetPostById(int id, string password)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/posts/" + id.ToString(),
                Method = Method.GET
            };
            request.AddParameter("password", password);

            return (JsonConvert.DeserializeObject<List<Post>>((await restClient.Execute(request)).Content)).First();
        }

        /// <summary>
        /// Gets the WordPress post corresponding to the specified slug
        /// </summary>
        public async Task<Post> GetPostBySlug(string slug)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/posts",
                Method = Method.GET
            };
            request.AddParameter("slug", slug);

            return (JsonConvert.DeserializeObject<List<Post>>((await restClient.Execute(request)).Content)).First();
        }

        /// <summary>
        /// Gets the password protected WordPress post corresponding to the specified slug
        /// </summary>
        public async Task<Post> GetPostBySlug(string slug, string password)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/posts",
                Method = Method.GET
            };
            request.AddParameter("slug", slug);
            request.AddParameter("password", password);

            return (JsonConvert.DeserializeObject<List<Post>>((await restClient.Execute(request)).Content)).First();
        }

        #endregion

        #region PostRevisions

        //to do after authentication is implemented

        #endregion

        #region Categories

        /// <summary>
        /// Gets all the post categories
        /// </summary>
        public async Task<List<Category>> GetAllCategories()
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/categories?per_page=100",
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<List<Category>>((await restClient.Execute(request)).Content);
        }

        /// <summary>
        /// Gets the post WordPress category associated with the specified Id
        /// </summary>
        public async Task<Category> GetCategoryById(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/categories/" + id.ToString(),
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<Category>((await restClient.Execute(request)).Content);
        }

        #endregion

        #region Tags

        /// <summary>
        /// Gets all the tags
        /// </summary>
        public async Task<List<Tag>> GetAllTags()
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/tags?per_page=100",
                Method = Method.GET
            };

            return (JsonConvert.DeserializeObject<List<Tag>>((await restClient.Execute(request)).Content));
        }

        /// <summary>
        /// Gets the WordPress tag corresponding to the specified Id
        /// </summary>
        public async Task<Tag> GetTagById(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/tags/" + id.ToString(),
                Method = Method.GET
            };

            return (JsonConvert.DeserializeObject<List<Tag>>((await restClient.Execute(request)).Content)).First();
        }

        /// <summary>
        /// Gets the WordPress tag corresponding to the specified slug
        /// </summary>
        public async Task<Tag> GetTagBySlug(string slug)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/tags",
                Method = Method.GET
            };
            request.AddParameter("slug", slug);

            return (JsonConvert.DeserializeObject<List<Tag>>((await restClient.Execute(request)).Content)).First();
        }

        #endregion

        #region Pages

        /// <summary>
        /// Gets all the WordPress pages
        /// </summary>
        public async Task<List<Page>> GetAllPages()
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/pages?per_page=100",
                Method = Method.GET
            };

            return (JsonConvert.DeserializeObject<List<Page>>((await restClient.Execute(request)).Content));
        }

        /// <summary>
        /// Gets the WordPress page corresponding to the specified Id
        /// </summary>
        public async Task<Page> GetPageById(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/pages/",
                Method = Method.GET
            };
            request.AddParameter("id", id.ToString());

            return (JsonConvert.DeserializeObject<List<Page>>((await restClient.Execute(request)).Content)).First();
        }

        /// <summary>
        /// Gets the password protected WordPress page corresponding to the specified Id
        /// </summary>
        public async Task<Page> GetPageById(int id, string password)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/pages/",
                Method = Method.GET
            };
            request.AddParameter("id", id.ToString());
            request.AddParameter("password", password);

            return (JsonConvert.DeserializeObject<List<Page>>((await restClient.Execute(request)).Content)).First();
        }

        /// <summary>
        /// Gets the WordPress page corresponding to the specified Slug
        /// </summary>
        public async Task<Page> GetPageBySlug(string slug)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/pages/",
                Method = Method.GET
            };
            request.AddParameter("slug", slug);

            return (JsonConvert.DeserializeObject<List<Page>>((await restClient.Execute(request)).Content)).First();
        }        

        /// <summary>
        /// Gets the password protected WordPress page corresponding to the specified slug
        /// </summary>
        public async Task<Page> GetPageBySlug(string slug, string password)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/pages",
                Method = Method.GET
            };
            request.AddParameter("slug", slug);
            request.AddParameter("password", password);

            return (JsonConvert.DeserializeObject<List<Page>>((await restClient.Execute(request)).Content)).First();
        }

        #endregion

        #region Comments

        /// <summary>
        /// Gets all the comments
        /// </summary>
        public async Task<List<Comment>> GetAllComments()
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/comments?per_page=100",
                Method = Method.GET
            };

            return (JsonConvert.DeserializeObject<List<Comment>>((await restClient.Execute(request)).Content));
        }

        /// <summary>
        /// Gets all the comments associated to the WordPress post corresponding to the specified Id
        /// </summary>
        public async Task<List<Comment>> GetPostComments(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/comments?per_page=100",
                Method = Method.GET
            };
            request.AddParameter("post", id);

            return (JsonConvert.DeserializeObject<List<Comment>>((await restClient.Execute(request)).Content));
        }

        /// <summary>
        /// Gets the WordPress comment corresponding to the specified Id
        /// </summary>
        public async Task<Comment> GetCommentById(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/comments/" + id.ToString(),
                Method = Method.GET
            };

            return (JsonConvert.DeserializeObject<List<Comment>>((await restClient.Execute(request)).Content)).First();
        }

        #endregion

        #region Taxonomies

        /// <summary>
        /// Gets all the taxonomies
        /// </summary>
        public async Task<List<Taxonomy>> GetAllTaxonomies()
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/taxonomies",
                Method = Method.GET
            };

            return (JsonConvert.DeserializeObject<List<Taxonomy>>((await restClient.Execute(request)).Content));
        }

        /// <summary>
        /// Gets the WordPress taxonomy corresponding to the specified Id
        /// </summary>
        public async Task<Taxonomy> GetTaxonomyById(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/taxonomies/" + id.ToString(),
                Method = Method.GET
            };

            return (JsonConvert.DeserializeObject<List<Taxonomy>>((await restClient.Execute(request)).Content)).First();
        }

        #endregion

        #region Media

        /// <summary>
        /// Gets all the Media
        /// </summary>
        public async Task<List<Media>> GetAllMedia()
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/media?per_page=100",
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<List<Media>>((await restClient.Execute(request)).Content);
        }

        /// <summary>
        /// Gets the WordPress Media corresponding to the specified Id
        /// </summary>
        public async Task<List<Media>> GetMediaById(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/media?id=" + id.ToString(),
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<List<Media>>((await restClient.Execute(request)).Content);
        }

        /// <summary>
        /// Gets the password protected WordPress Media corresponding to the specified Id
        /// </summary>
        public async Task<List<Media>> GetMediaById(int id, string password)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/media?id=" + id.ToString(),
                Method = Method.GET
            };
            request.AddParameter("password", password);

            return JsonConvert.DeserializeObject<List<Media>>((await restClient.Execute(request)).Content);
        }

        /// <summary>
        /// Gets the Media associated to the post corresponding to the specified Id
        /// </summary>
        public async Task<List<Media>> GetPostMedia(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/media?parent=" + id.ToString(),
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<List<Media>>((await restClient.Execute(request)).Content);
        }

        #endregion

        #region Users

        //to do after authentication is implemented

        #endregion

        #region PostTypes

        /// <summary>
        /// Gets all the PostTypes
        /// </summary>
        public async Task<List<PostType>> GetAllPostTypes()
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/types",
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<List<PostType>>((await restClient.Execute(request)).Content);
        }

        /// <summary>
        /// Gets the WordPress PostTypes corresponding to the specified Id
        /// </summary>
        public async Task<List<PostType>> GetPostTypeById(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/types?id=" + id.ToString(),
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<List<PostType>>((await restClient.Execute(request)).Content);
        }

        #endregion

        #region PostStatuses

        /// <summary>
        /// Gets all the PostTypes
        /// </summary>
        public async Task<List<PostStatus>> GetAllPostStatuses()
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/statuses",
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<List<PostStatus>>((await restClient.Execute(request)).Content);
        }

        /// <summary>
        /// Gets the WordPress PostTypes corresponding to the specified Id
        /// </summary>
        public async Task<List<PostStatus>> GetPostStatusById(int id)
        {
            var restClient = new RestSharp.Portable.HttpClient.RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "wp-json/wp/v2/statuses?id=" + id.ToString(),
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<List<PostStatus>>((await restClient.Execute(request)).Content);
        }

        #endregion

        #region Settings

        //to do after authentication is implemented

        #endregion
    }
}

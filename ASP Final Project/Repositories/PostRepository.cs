using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TumblrRipOff.Models;
using Microsoft.Extensions.Configuration;

namespace TumblrRipOff.Repositories
{
    public class PostRepository : IPostRepository
    {
        private TumblrConfiguration _SnapShotData;
        private IConfiguration _Config;

        public PostRepository(IOptionsSnapshot<TumblrConfiguration> snap, IConfiguration config)
        {
            _SnapShotData = snap.Value;
            _Config = config;
        }

        public virtual void DeletePost(int PostID)
        {
            using (SqlConnection connection = new SqlConnection(GetConnection()))
            {
                using (SqlCommand command = new SqlCommand("DeletePost", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", PostID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public virtual PostModel GetPost(int PostId)
        {
            PostModel post = null;
            using (SqlConnection connection = new SqlConnection(GetConnection()))
            {
                using (SqlCommand command = new SqlCommand("GetPost", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PostId", PostId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            post = Convert(reader);
                        }
                    }
                }
            }
            return post;
        }

        //public virtual int GetPostCount(string userName)
        //{
        //    int count = -1;
        //    using (SqlConnection connection = new SqlConnection(GetConnection()))
        //    {
        //        using (SqlCommand command = new SqlCommand("GetPostCount", connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@UserName", userName);

        //            connection.Open();
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    count = (int)reader["Count"];
        //                }
        //            }
        //        }
        //    }
        //    return count;
        //}

        public virtual List<PostModel> GetPosts(string UserName = "")
        {
            List<PostModel> page = new List<PostModel>();
            using (SqlConnection connection = new SqlConnection(GetConnection()))
            {
                bool check = (UserName == null || UserName == "");
                using (SqlCommand command = new SqlCommand((check) ? "GetPosts" : "GetPostsByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (!check) command.Parameters.AddWithValue("@Creator", UserName);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            page.Add(Convert(reader));
                        }
                    }
                }
            }
            return page;
        }

        public virtual void SavePost(PostModel model)
        {
            using (SqlConnection connection = new SqlConnection(GetConnection()))
            {
                using (SqlCommand command = new SqlCommand("InsertPost", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Title", model.Title);
                    command.Parameters.AddWithValue("@ImageUrl", model.ImageUrl);
                    command.Parameters.AddWithValue("@PostText", model.PostText);
                    command.Parameters.AddWithValue("@Creator", model.Creator);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        protected PostModel Convert(SqlDataReader reader)
        {
            PostModel post = new PostModel();

            post.PostID = (int)reader["PostID"];
            post.Title = reader["Title"].ToString();
            post.ImageUrl = reader["ImageURL"].ToString();
            post.PostText = reader["PostText"].ToString();
            post.Creator = reader["Creator"].ToString();
            post.TimeStamp = (DateTime)reader["Timestamp"];

            return post;
        }

        private string GetConnection()
        {
            return _Config.GetConnectionString("Lab8ContextConnection");
        }
    }
}

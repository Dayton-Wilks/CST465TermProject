using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TumblrRipOff.Models;

namespace TumblrRipOff.Repositories
{
    public class PostRepository : IPostRepository
    {
        private TumblrConfiguration _Configuration;

        public PostRepository(IOptionsSnapshot<TumblrConfiguration> configuration)
        {
            _Configuration = configuration.Value;
        }

        public virtual void DeletePost(int PostID)
        {
            using (SqlConnection connection = new SqlConnection())
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
            using (SqlConnection connection = new SqlConnection())
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

        public virtual int GetPostCount(string userName)
        {
            int count = -1;
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand("GetPostCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", userName);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            count = (int)reader["Count"];
                        }
                    }
                }
            }
            return count;
        }

        public virtual List<PostModel> GetPosts(int index, string UserName = "")
        {
            List<PostModel> page = null;
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand("GetPosts", connection))
                {
                    int rowStart = index * _Configuration.PageSize;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RowStart", rowStart);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@RowCount", rowStart + _Configuration.PageSize);

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
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand("SavePost", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", model.PostID);
                    command.Parameters.AddWithValue("@Title", model.Title);
                    command.Parameters.AddWithValue("@ImageUrl", model.ImageUrl);
                    command.Parameters.AddWithValue("@PostText", model.PostText);
                    command.Parameters.AddWithValue("@Creator", model.Creator);
                    command.Parameters.AddWithValue("@ID", model.PostID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        protected PostModel Convert(SqlDataReader reader)
        {
            PostModel post = new PostModel();

            post.PostID = (int)reader["ID"];
            post.Title = reader["Title"].ToString();
            post.ImageUrl = reader["ImageUrl"].ToString();
            post.PostText = reader["PostText"].ToString();
            post.Creator = reader["Creator"].ToString();
            post.TimeStamp = (DateTime)reader["Timestamp"];

            return post;
        }
    }
}

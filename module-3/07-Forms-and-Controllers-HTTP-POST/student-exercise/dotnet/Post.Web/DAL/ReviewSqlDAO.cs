using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        ///
        ///
        public IList<Review> GetAllReviews()
        {
            IList<Review> reviews = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM reviews", conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var review = new Review()
                        {

                            Username = Convert.ToString(reader["username"]),
                            Rating = Convert.ToInt32(reader["rating"]),
                            ReviewTitle = Convert.ToString(reader["review_title"]),
                            ReviewText = Convert.ToString(reader["review_text"]),
                            ReviewDate = Convert.ToDateTime(reader["review_date"])
                        };

                        reviews.Add(review);
                    }
                }

                return reviews;

            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public int SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd =
                        new SqlCommand(
                            $"INSERT into reviews(username,rating, review_title, review_text) values(@username, @rating, @review_title,@review_text",
                            conn);
                   
                    cmd.Parameters.AddWithValue("@username", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@review_title", newReview.ReviewTitle);
                    cmd.Parameters.AddWithValue("@review_text", newReview.ReviewText);
                    var reader = cmd.ExecuteReader();

                }

            }
            catch (Exception ex)
            {

            }

            return 0;
        }
    }
}

       


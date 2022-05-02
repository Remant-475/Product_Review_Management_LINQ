using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_Review_Linq
{
    class Management
    {

        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> listProductReview)
        {

            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
                Console.WriteLine("-----------------------------------------------------------------");
            }
        }
        public void SelectedRecords(List<ProductReview> listProductReview)
        {


            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                               && productReviews.Rating > 3
                               select productReviews;
            Console.WriteLine("Rating greater than 3 with product id of 1,4,or 9: ");

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
                Console.WriteLine("-----------------------------------------------------------------");
            }
        }
    }
}
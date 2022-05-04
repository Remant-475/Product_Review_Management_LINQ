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
        public void CountOfRecords(List<ProductReview> listProductReview)
        {
            
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("Count of records by ProductID: ");
            foreach (var list in recordedData)
            {
                Console.WriteLine("ID:" + list.ProductID + "----->" + "Count: " + list.Count);

            }
        }
        public void ProductIDAndReview(List<ProductReview> listProductReview)
        {
          
            var recordedData = listProductReview.Select(x => new { ProductID = x.ProductID, Review = x.Review });
            Console.WriteLine("ID with Review");
            foreach (var list in recordedData)
            {
                
                Console.WriteLine("ID:" + list.ProductID + "=====>" + list.Review);

            }
        }
        public void SkipTopFiveRecords(List<ProductReview> listProductReview)
        {

            var recordedData = (from productReviews in listProductReview
                                select productReviews).Skip(5);
            Console.WriteLine("Retrieving records after skipping top 5 records- ");
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);

            }
        }
        public void SelectProductIDAndReviews(List<ProductReview> listProductReview)
        {
           
            var recordedData = listProductReview.Select(x => new { x.ProductID, x.Review });
            foreach (var list in recordedData)
            {
                
                Console.WriteLine("ID:" + list.ProductID + "=====>" + list.Review);
            }
        }
        public void IsLikeValueIsTrue(List<ProductReview> ProductReview)
        {
            var RecordedData = (from productReview in ProductReview where (productReview.isLike == true) select productReview);
            foreach (var list in RecordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike:- " + list.isLike);
            }
        }
    }
}
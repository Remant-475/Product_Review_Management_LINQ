using System;
using System.Collections.Generic;
using System.Linq;
namespace Product_Management_Review_Linq
{
    class ProductReviewManagement
    {
        readonly List<ProductReview> ProductReviewList;
        public ProductReviewManagement()
        {
            ProductReviewList = new List<ProductReview>()
            {
                 new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProductID=5,UserID=1,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="bas",isLike=true},
                new ProductReview(){ProductID=8,UserID=1,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProductID=8,UserID=1,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=10,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=11,UserID=1,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=12,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=12,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=13,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=14,UserID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProductID=15,UserID=1,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=15,UserID=1,Rating=1,Review="bad",isLike=true},
                new ProductReview(){ProductID=15,UserID=1,Rating=2,Review="bad",isLike=true},
                new ProductReview(){ProductID=15,UserID=1,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProductID=18,UserID=1,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=19,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=20,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=21,UserID=1,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=22,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=22,UserID=1,Rating=8,Review="nice",isLike=true},
               new ProductReview(){ProductID=23,UserID=10,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=23,UserID=10,Rating=7,Review="Good",isLike=true},
               new ProductReview(){ProductID=24,UserID=10,Rating=8,Review="nice",isLike=true},
               new ProductReview(){ProductID=24,UserID=10,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=25,UserID=10,Rating=3,Review="bad",isLike=true}
            };
        }
        public void DisplayList(List<ProductReview> ProductReviewsList)
        {
            foreach (var ProductReview  in ProductReviewsList)
            {
                Console.WriteLine("Product ID: {0}, \nUser ID: {1}, \nRating: {2}, \nReview: {3}, " +
                    "\nIs Like: {4} \n", ProductReview.ProductID, ProductReview.UserID, ProductReview.Rating, ProductReview.Review,
                     ProductReview.isLike);
            }
        }

        public static void Main(string[] args)
        
          
            {
                Console.WriteLine("Welcome to Product Review Management using LINQ");
                ProductReviewManagement program = new ProductReviewManagement();
                Management management = new Management();
            int option;
                do
                {
                    Console.WriteLine("\n-----------------------------------------------");
                    Console.WriteLine("Choose a Number:");
                    Console.WriteLine("1 to display the list of items");
                Console.WriteLine("2 Retrieving Top 3 records based on rating: ");
                Console.WriteLine("3- Retrieving records with specific conditions: ");
                Console.WriteLine("4- Count of records by product id ");
                Console.WriteLine("5- Retrieving review by Product ID:");
                Console.WriteLine("6- Skipping top 5 records:");
                Console.WriteLine("7- Retrieving review by Product ID:");
                Console.WriteLine("8-Retrive whose islike value is true");
                Console.WriteLine("9-Average rating of ProductID");
                Console.WriteLine("10-Record with Nice Review");
                Console.WriteLine("0 to EXIT");
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------------\n");
                    switch (option)
                    {
                        case 1:
                            program.DisplayList(program.ProductReviewList);
                            break;

                    case 2:
                        management.TopRecords(program.ProductReviewList);
                        break;
                    case 3: management.SelectedRecords(program.ProductReviewList);
                        break;
                        case 4:
                        management.CountOfRecords(program.ProductReviewList);
                        break;
                    case 5: 
                        management.ProductIDAndReview(program.ProductReviewList);
                        break;
                    case 6:
                        management.SkipTopFiveRecords(program.ProductReviewList);
                        break;
                        case 7:
                        management.SelectProductIDAndReviews(program.ProductReviewList);
                        break;
                    case 8:
                        management.IsLikeValueIsTrue(program.ProductReviewList);
                        break;
                    case 9:
                        management.AverageRatingEachProductID(program.ProductReviewList);
                        break;
                    case 10:
                        management.RecordsWithNiceReview(program.ProductReviewList);
                        break;
                    case 11:
                        management.GetRecordsForUserIdTen(program.ProductReviewList);
                        break;
                    default:
                            break;
                    }

                } while (option != 0);
            }
        }
    }





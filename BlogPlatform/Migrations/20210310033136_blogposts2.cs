using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class blogposts2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Body", "CategoryId", "ColorId", "Image", "PublishDate", "Title" },
                values: new object[] { null, "It's been a few years since my husband and I ran the Spartan Sprint in 2018 with my students. It was a blast and an experience to remember. Climbing, running, mud pits, and coaching my students through that fear of heights! Even though we got pulled off the course for a freak lightning storm, we stuck it out and got back out there after the storm cleared. Jumping that fire was an awesome moment! Giving my body the time to heal and working to get back to where I was before baby. But my goal is to run another one in 2022. I can't wait!", 1, 6, "Images/Spartan2.jpg", "3/6/21", "Spartan" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "CategoryId", "ColorId", "Image", "PublishDate", "Title" },
                values: new object[] { "Miles is starting to eat solid foods! He enjoys blueberries, broccoli, and tofu so far. Today he tried mango and it was an instant hit!", 2, 3, "Images/Mango.jpg", "3/7/21", "Mango" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Body", "CategoryId", "ColorId", "Image", "PublishDate", "Title" },
                values: new object[] { "Washburne is six years old now. Over the years he has learned to accept Nate playing guitar. Don't let that fool you though, this drama puppy used to lay there and cry anytime Nate even opened his guitar case as a wee pup.", 3, 7, "Images/Guitar.jpg", "03/09/21", "Guitar" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "ColorId", "Image", "PublishDate", "Title" },
                values: new object[] { 9, "Teacup", "Miles went on his first adventure in the backyard today! He got to play with leaves, zoom down his little tykes slide, and toddle after his doggo around the yard! Excited for more days like this!", 4, 1, "Images/Backyard.jpg", "3/8/21", "Backyard" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Body", "CategoryId", "ColorId", "Image", "PublishDate", "Title" },
                values: new object[] { "Teacup", "Miles is starting to eat solid foods! He enjoys blueberries, broccoli, and tofu so far. Today he tried mango and it was an instant hit!", 2, 3, "Images/Mango.jpg", "3/7/21", "Mango" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "CategoryId", "ColorId", "Image", "PublishDate", "Title" },
                values: new object[] { "Washburne is six years old now. Over the years he has learned to accept Nate playing guitar. Don't let that fool you though, this drama puppy used to lay there and cry anytime Nate even opened his guitar case as a wee pup.", 3, 7, "Images/Guitar.jpg", "03/09/21", "Guitar" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Body", "CategoryId", "ColorId", "Image", "PublishDate", "Title" },
                values: new object[] { "Miles went on his first adventure in the backyard today! He got to play with leaves, zoom down his little tykes slide, and toddle after his doggo around the yard! Excited for more days like this!", 4, 1, "Images/Backyard.jpg", "3/8/21", "Backyard" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "ColorId", "Image", "PublishDate", "Title" },
                values: new object[] { 5, null, "It's been a few years since my husband and I ran the Spartan Sprint in 2018 with my students. It was a blast and an experience to remember. Climbing, running, mud pits, and coaching my students through that fear of heights! Even though we got pulled off the course for a freak lightning storm, we stuck it out and got back out there after the storm cleared. Jumping that fire was an awesome moment! Giving my body the time to heal and working to get back to where I was before baby. But my goal is to run another one in 2022. I can't wait!", 1, 6, "Images/Spartan2.jpg", "3/6/21", "Spartan" });
        }
    }
}

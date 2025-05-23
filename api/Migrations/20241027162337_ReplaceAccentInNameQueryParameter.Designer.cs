﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Models;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(UCReviewsContext))]
    [Migration("20241027162337_ReplaceAccentInNameQueryParameter")]
    partial class ReplaceAccentInNameQueryParameter
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiningHall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncludedInMealPlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameQueryParameter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DiningHall");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Retail Dining",
                            Description = "Located on the second floor of the Tangeman University Center, Cincy Grill is home to grill favorites such as chicken tenders, smash burgers, loaded tots and much more.",
                            IncludedInMealPlan = "Meal Exchange",
                            Location = "Cincy Grill - Tangemen University Center, 2701 Bearcat Way",
                            Name = "Cincy Grill",
                            NameQueryParameter = "CincyGrill"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Retail Dining",
                            Description = "A favorite stop for breakfast, lunch, or dinner, Chick-fil-A offers premium chicken sandwiches, salads, nuggets, waffle fries, and more.",
                            IncludedInMealPlan = "No",
                            Location = "Chick-Fil-A - Tangeman University Center, 2701 Bearcat Way",
                            Name = "Chick-fil-A",
                            NameQueryParameter = "ChickFilA"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Café",
                            Description = "Teachers Café offers a wide variety of grab ‘n go sandwiches, salads, fruit cups, parfaits and more. If you need a pick-me-up, we also serve Rooted Grounds coffee.",
                            IncludedInMealPlan = "Meal Exchange",
                            Location = "Teachers Café, 2610 University Circle",
                            Name = "Teachers Café",
                            NameQueryParameter = "TeachersCafé"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Café",
                            Description = "Bearcats Café, located in TUC offers both a grab and go style meal or a hot meal to go. \nBABB (Bad-Ass Breakfast Burritos) - Satisfy your early-morning or late-night cravings with burritos packed with premium meats, crispy potatoes, cheese, and eggs, all wrapped in a soft tortilla. Top it off with our addictive sauces for a truly satisfying meal. \nStuffed Sensation - Treat yourself to Otis Spunkmeyer cookies stuffed with irresistible fillings like Oreos® and Reese’s. These decadent cookies are sure to be a hit, whether served fresh or pre-packaged. \nTo the Max Mexican - Build a healthy, flavorful bowl or burrito at To The Max Mexican. Choose from fresh, authentically seasoned ingredients, carefully portioned for a balanced meal. \nAC BBQ - Enjoy rich, flavorful barbecue rooted in Black excellence and community, created by Anthony Anderson and Cedric the Entertainer. AC Barbeque brings people together with its delicious, culturally inspired dishes.",
                            IncludedInMealPlan = "Carryout and Limited Seating",
                            Location = "Bearcats Café - Tangeman University Center, 2701 Bearcat Way",
                            Name = "Bearcats Café",
                            NameQueryParameter = "BearcatsCafé"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Café",
                            Description = "Campus View Café offers a wide variety of grab ‘n go sandwiches, salads, fruit cups, parfaits and more. If you need a pick-me-up, we also serve Rooted Grounds coffee.",
                            IncludedInMealPlan = "Meal Exchange",
                            Location = "Campus View Café - University Hall, 51 Goodman Avenue - Medical Campus",
                            Name = "CampusView Café",
                            NameQueryParameter = "CampusViewCafé"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Resident Dining",
                            Description = "On the Green is an all-you-care-to-eat dining facility that boasts 8 dining stations, dishing up comfort food classics, made-to-order stir-fry and pasta, homemade soups, fresh salads with local greens, and in-house baked desserts. On the Green also features Simple Servings, an allergen-friendly station committed to providing delicious, wholesome meals safely prepared free of 8 of the top allergens, plus gluten as well as Simple Zone a “pantry” where food items needed by customers with celiac disease or food allergies can be housed with precautions against cross-contact can be found.",
                            IncludedInMealPlan = "Dine In",
                            Location = "On The Green - Marian Spencer Hall, 2911 Scioto Lane",
                            Name = "On the Green",
                            NameQueryParameter = "OTG"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Resident Dining",
                            Description = "MarketPointe is a 37,000 foot state-of-the-art dining facility that boasts 8 dining stations that put you at the center of a culinary food hall experience. From delicious, plant-forward dishes and nourishing made-to-order sandwiches to authentic global bowls and craveable Latin-infused flavors, MarketPointe has something for everyone. MarketPointe also features Simple Servings, an allergen-friendly station committed to providing delicious, wholesome meals safely prepared free of 8 of the top allergens, plus gluten. Cap your dining experience with a fresh-roasted cup of local Rooted Grounds coffee and something sweet.",
                            IncludedInMealPlan = "Dine In",
                            Location = "MarketPointe - Siddal Hall, 2580 Corbett Drive",
                            Name = "MarketPointe",
                            NameQueryParameter = "MarketPointe"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Retail Dining",
                            Description = "At The Halal Shack, our food is Made with Love. Our culture is rooted in Middle Eastern & Mediterranean heritage which embodies bonds that are created through sharing food Made With Love. Find us at Tangeman University Center.",
                            IncludedInMealPlan = "Meal Exchange after 2 P.M.",
                            Location = "The Halal Shack - Tangeman University Center, 2701 Bearcat Way",
                            Name = "Halal Shack",
                            NameQueryParameter = "HalalShack"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Retail Dining",
                            Description = "Pei Wei at Tangeman University Center offers authentic, Asian-inspired cuisine without compromising on quality or convenience.",
                            IncludedInMealPlan = "No",
                            Location = "Pei Wei - Tangeman University Center, 2701 Bearcat Way",
                            Name = "Pei Wei",
                            NameQueryParameter = "PeiWei"
                        },
                        new
                        {
                            Id = 10,
                            Category = "CStore",
                            Description = "Market on Main is your mini-grocery store in the heart of campus! Water by the case, dairy, snacks, grab-and-go, heat-and-eat meals, beverages and more are available for all of your convenience needs.",
                            IncludedInMealPlan = "No",
                            Location = "Market on Main, 2820 Bearcat Way",
                            Name = "Market on Main",
                            NameQueryParameter = "MarketOnMain"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Resident Dining",
                            Description = "Center Court is an expansive all-you-care-to-eat facility that boasts over a dozen unique dining destinations to feed hungry Bearcats. Enjoy favorites like pizza, handhelds, Indian cuisine from Choolaah, and made-to-order handcrafted sandwiches to an expansive salad bar, homemade soups and indulgent desserts. Center Court also features Simple Servings, an allergen-friendly station committed to providing delicious, wholesome meals safely prepared free of 8 of the top allergens, plus gluten.",
                            IncludedInMealPlan = "Dine In",
                            Location = "Center Court - Campus Recreation Center, 2810 Woodside Drive",
                            Name = "Center Court",
                            NameQueryParameter = "CenterCourt"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Café",
                            Description = "DAAP Café serves your favorite breakfast, lunch, and dinner options. The Café also serves Simply to Go sandwiches, salads, & snacks for students who are hungry and on the go. If you need a pick-me-up, we also serve iced bubble tea and Rooted Grounds coffee.",
                            IncludedInMealPlan = "Meal Exchange",
                            Location = "DAAP Café @ Aronoff Center, 2624 Clifton Avenue",
                            Name = "DAAP Café",
                            NameQueryParameter = "DaapCafé"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Café",
                            Description = "Partnering with the local Pneuma Coffee Roasters, renowned for their commitment to quality, The 86 Coffee Bar offers an array of meticulously crafted brews, from rich espressos to velvety lattes. Moreover, the menu extends beyond traditional offerings, with specialty drinks inspired by the creativity of CCM's community.",
                            IncludedInMealPlan = "No",
                            Location = "College-Conservatory of Music, 2604 Backstage Drive",
                            Name = "The 86 Coffee Bar",
                            NameQueryParameter = "86Coffee"
                        },
                        new
                        {
                            Id = 14,
                            Category = "CStore",
                            Description = "Salty and sweet snacks, grab-and-go salads, sandwiches, fruit cups, heat-and-eat meals, beverages and more are available at the Mainstreet Express Mart.",
                            IncludedInMealPlan = "No",
                            Location = "Tangeman University Center, 2701 Bearcat Way",
                            Name = "Mainstreet Express Mart",
                            NameQueryParameter = "Mainstreet"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Café",
                            Description = "Starbucks roasts high-quality whole bean coffees. Other premium beverage options include rich espressos, lattes, and Tazo Teas. Starbucks also serves a variety of pastries and confections.",
                            IncludedInMealPlan = "No",
                            Location = "Starbucks @ Lindner Hall, 2906 Woodside Drive",
                            Name = "Starbucks - Linder",
                            NameQueryParameter = "Starbucks_Linder"
                        },
                        new
                        {
                            Id = 16,
                            Category = "Café",
                            Description = "Starbucks roasts high-quality whole bean coffees. Other premium beverage options include rich espressos, lattes, and Tazo Teas. Starbucks also serves a variety of pastries and confections.",
                            IncludedInMealPlan = "No",
                            Location = "Starbucks @ Langsam Library, 2911 Woodside Drive",
                            Name = "Starbucks - Langsam",
                            NameQueryParameter = "Starbucks_Langsam"
                        },
                        new
                        {
                            Id = 17,
                            Category = "Resident Dining",
                            Description = "Stadium View Café features Sicilian pizza and a build-your-own rice bowl station. \nThe Café also serves an exclusive game day menu during football season.",
                            IncludedInMealPlan = "Dine In and Carryout",
                            Location = "Bearcats Café - Tangeman University Center, 2701 Bearcat Way",
                            Name = "Stadium View Café",
                            NameQueryParameter = "StadiumView"
                        },
                        new
                        {
                            Id = 18,
                            Category = "Café",
                            Description = "Starbucks roasts high-quality whole bean coffees. Other premium beverage options include rich espressos, lattes, and Tazo Teas. Starbucks also serves a variety of pastries and confections.",
                            IncludedInMealPlan = "No",
                            Location = "Starbucks @ Medical Science Building, 234 Goodman Drive",
                            Name = "Starbucks - Medical Campus",
                            NameQueryParameter = "Starbucks_Medical"
                        });
                });

            modelBuilder.Entity("api.Models.Dorm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameQueryParameter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dorm", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = "$",
                            Description = "Located in the heart of Clifton Heights, Calhoun Hall is known for its welcoming atmosphere and scenic views. Its community areas and study floor make it the perfect place to meet neighbors, cultivate friendships, and get involved in the UC community! The proximity to off- and on-campus dining options, as well as entertainment on Calhoun Street makes it an exciting and classic option when it comes to choosing where to live.",
                            Name = "Calhoun Hall",
                            NameQueryParameter = "Calhoun",
                            Style = "Traditional"
                        },
                        new
                        {
                            Id = 2,
                            Cost = "$$$",
                            Description = "Campus Recreation Center Hall is perfect for students that desire productivity and focus in their day-to-day life. It is located on MainStreet connected to the Rec Center and CenterCourt dining hall, making it the perfect environment for motivation.",
                            Name = "CRC",
                            NameQueryParameter = "CRC",
                            Style = "Suite"
                        },
                        new
                        {
                            Id = 3,
                            Cost = "$",
                            Description = "This newly renovated hall fosters some of the strongest community on campus and puts you at the center of so much activity. Sitting in the middle of campus and just a short walk from the sprawling Sigma Sigma Commons.",
                            Name = "Dabney Hall",
                            NameQueryParameter = "Dabney",
                            Style = "Traditional"
                        },
                        new
                        {
                            Id = 4,
                            Cost = "$",
                            Description = "Daniels Hall most likely matches what comes to mind when you think of a college residence hall. Its traditional-style structure establishes a welcoming and very social atmosphere on every floor.",
                            Name = "Daniels Hall",
                            NameQueryParameter = "Daniels",
                            Style = "Traditional"
                        },
                        new
                        {
                            Id = 5,
                            Cost = "$$",
                            Description = "UC’s newest addition to University Housing and is a wonderful place for students to live. Its unique architecture allows for suite-style rooms.",
                            Name = "Marian Spencer",
                            NameQueryParameter = "Marian_Spencer",
                            Style = "Junior Suite"
                        },
                        new
                        {
                            Id = 6,
                            Cost = "$$$$",
                            Description = "Renovated in 2013, Morgens Hall was built as one of the Three Sisters and is now a state-of-the-art building with many awards for its eco-friendly design.",
                            Name = "Morgens Hall",
                            NameQueryParameter = "Morgens",
                            Style = "Apartment"
                        },
                        new
                        {
                            Id = 7,
                            Cost = "$$$",
                            Description = "Schneider Hall is in a wonderful part of eastern main campus along Jefferson Avenue, and is close to multiple dining centers, shops, and restaurants.",
                            Name = "Schneider Hall",
                            NameQueryParameter = "Schneider",
                            Style = "Suite"
                        },
                        new
                        {
                            Id = 8,
                            Cost = "$$$$",
                            Description = "Located close to multiple dining centers, Scioto Hall provides a spacious environment with suite-style living and plenty of community spaces.",
                            Name = "Scioto Hall",
                            NameQueryParameter = "Scioto",
                            Style = "Apartment"
                        },
                        new
                        {
                            Id = 9,
                            Cost = "$",
                            Description = "Siddall Hall includes the CCM themed community and is known for its communal activities such as ping pong tournaments and late-night ice cream parties.",
                            Name = "Siddall Hall",
                            NameQueryParameter = "Siddall",
                            Style = "Traditional"
                        },
                        new
                        {
                            Id = 10,
                            Cost = "$$$$",
                            Description = "One of UC’s newest off-campus housing communities, The Deacon offers distinctive amenities such as a movie theater and arcade.",
                            Name = "The Deacon",
                            NameQueryParameter = "Deacon",
                            Style = "Apartment"
                        },
                        new
                        {
                            Id = 11,
                            Cost = "$$$$",
                            Description = "Newly constructed apartments just three blocks from campus, with floor plans and amenities ideal for building community among residents.",
                            Name = "The Eden",
                            NameQueryParameter = "Eden",
                            Style = "Apartment"
                        },
                        new
                        {
                            Id = 12,
                            Cost = "$$$",
                            Description = "Turner Hall is home to multiple Living-Learning Communities and has ADA accessible accommodations available.",
                            Name = "Turner Hall",
                            NameQueryParameter = "Turner",
                            Style = "Suite"
                        },
                        new
                        {
                            Id = 13,
                            Cost = "$$$$",
                            Description = "University Edge apartments provide near-campus residency options with a sprawling courtyard and proximity to the Cincinnati Zoo.",
                            Name = "University Edge",
                            NameQueryParameter = "Edge",
                            Style = "Apartment"
                        },
                        new
                        {
                            Id = 14,
                            Cost = "$$$$",
                            Description = "University Park Apartments offer students an off-campus lifestyle with all the benefits of on-campus living, above many restaurants and shops.",
                            Name = "UPA",
                            NameQueryParameter = "UPA",
                            Style = "Apartment"
                        },
                        new
                        {
                            Id = 15,
                            Cost = "$$$$",
                            Description = "Located on Calhoun Street, U Square provides apartment-style living with a relaxing and independent lifestyle while offering convenience to businesses.",
                            Name = "U Square",
                            NameQueryParameter = "USquare",
                            Style = "Apartment"
                        });
                });

            modelBuilder.Entity("api.Models.ParkingGarage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Campus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PermitRequired")
                        .HasColumnType("bit");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("ParkingGarage", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "CCM Blvd, Cincinnati, OH 45219",
                            Campus = "Uptown Campus",
                            Latitude = 39.129894,
                            Longitude = -84.516852,
                            Name = "CCM Garage",
                            PermitRequired = false,
                            Slug = "ccm"
                        },
                        new
                        {
                            Id = 2,
                            Address = "230 Calhoun St, Cincinnati, OH 45219",
                            Campus = "Uptown Campus",
                            Latitude = 39.128439,
                            Longitude = -84.516615999999999,
                            Name = "Calhoun Garage",
                            PermitRequired = false,
                            Slug = "calhoun"
                        },
                        new
                        {
                            Id = 3,
                            Address = "2935 Campus Green Dr, Cincinnati, OH 45221",
                            Campus = "Uptown Campus",
                            Latitude = 39.135716000000002,
                            Longitude = -84.515223000000006,
                            Name = "Campus Green Garage",
                            PermitRequired = false,
                            Slug = "campus-green"
                        },
                        new
                        {
                            Id = 4,
                            Address = "CCM Blvd, Cincinnati, OH 45219",
                            Campus = "Uptown Campus",
                            Latitude = 39.134303000000003,
                            Longitude = -84.517270999999994,
                            Name = "Clifton Court Garage",
                            PermitRequired = false,
                            Slug = "clifton-court"
                        },
                        new
                        {
                            Id = 5,
                            Address = "2915 Clifton Ave, Cincinnati, OH 45220",
                            Campus = "Uptown Campus",
                            Latitude = 39.134689999999999,
                            Longitude = -84.520307000000003,
                            Name = "Clifton Lots",
                            PermitRequired = true,
                            Slug = "clifton-lots"
                        },
                        new
                        {
                            Id = 6,
                            Address = "2529 Scioto Ln, Cincinnati, OH 45219",
                            Campus = "Uptown Campus",
                            Latitude = 39.129001000000002,
                            Longitude = -84.512904000000006,
                            Name = "Corry Garage",
                            PermitRequired = false,
                            Slug = "corry"
                        },
                        new
                        {
                            Id = 7,
                            Address = "3080 Exploration Ave, Cincinnati, OH 45206",
                            Campus = "Uptown Campus",
                            Latitude = 39.134089000000003,
                            Longitude = -84.494940999999997,
                            Name = "Digital Futures",
                            PermitRequired = false,
                            Slug = "digital-futures"
                        },
                        new
                        {
                            Id = 8,
                            Address = "2630 Stratford Ave, Cincinnati, OH 45220",
                            Campus = "Uptown Campus",
                            Latitude = 39.130840999999997,
                            Longitude = -84.521377000000001,
                            Name = "Stratford Heights Garage",
                            PermitRequired = true,
                            Slug = "stratford-heights"
                        },
                        new
                        {
                            Id = 9,
                            Address = "40 W University Ave, Cincinnati, OH 45221",
                            Campus = "Uptown Campus",
                            Latitude = 39.134614999999997,
                            Longitude = -84.510986000000003,
                            Name = "University Avenue Garage",
                            PermitRequired = false,
                            Slug = "university-avenue"
                        },
                        new
                        {
                            Id = 10,
                            Address = "200 Varsity Village Drive, Cincinnati, OH 45221",
                            Campus = "Uptown Campus",
                            Latitude = 39.130166000000003,
                            Longitude = -84.515963999999997,
                            Name = "Varsity Village Garage",
                            PermitRequired = false,
                            Slug = "varsity-village"
                        },
                        new
                        {
                            Id = 11,
                            Address = "2913 Woodside Drive, Cincinnati, OH 45219",
                            Campus = "Uptown Campus",
                            Latitude = 39.135024999999999,
                            Longitude = -84.515180000000001,
                            Name = "Woodside Avenue Garage",
                            PermitRequired = false,
                            Slug = "woodside-avenue"
                        },
                        new
                        {
                            Id = 12,
                            Address = "3232 Healing Way, Cincinnati, OH 45229",
                            Campus = "Medical Campus",
                            Latitude = 39.138082474177075,
                            Longitude = -84.501192464167943,
                            Name = "Blood Cancer Healing Center",
                            PermitRequired = false,
                            Slug = "blood-cancer-healing-center"
                        },
                        new
                        {
                            Id = 13,
                            Address = "3223 Eden Ave, Cincinnati, OH 45220",
                            Campus = "Medical Campus",
                            Latitude = 39.137669000000002,
                            Longitude = -84.505159000000006,
                            Name = "Eden Garage",
                            PermitRequired = false,
                            Slug = "eden"
                        },
                        new
                        {
                            Id = 14,
                            Address = "151 Goodman Dr, Cincinnati, OH 45219",
                            Campus = "Medical Campus",
                            Latitude = 39.138082474177075,
                            Longitude = -84.501192464167943,
                            Name = "Kingsgate Garage",
                            PermitRequired = false,
                            Slug = "kingsgate"
                        });
                });

            modelBuilder.Entity("api.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DiningHallId")
                        .HasColumnType("int");

                    b.Property<int?>("DormId")
                        .HasColumnType("int");

                    b.Property<int?>("ParkingGarageId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("StarRating")
                        .HasPrecision(2, 1)
                        .HasColumnType("decimal(2,1)");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiningHallId");

                    b.HasIndex("DormId");

                    b.HasIndex("ParkingGarageId");

                    b.HasIndex("UserId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PasswordExpiration")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Salt")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("api.Models.Review", b =>
                {
                    b.HasOne("DiningHall", "DiningHall")
                        .WithMany("Reviews")
                        .HasForeignKey("DiningHallId");

                    b.HasOne("api.Models.Dorm", "Dorm")
                        .WithMany("Reviews")
                        .HasForeignKey("DormId");

                    b.HasOne("api.Models.ParkingGarage", "ParkingGarage")
                        .WithMany("Reviews")
                        .HasForeignKey("ParkingGarageId");

                    b.HasOne("api.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiningHall");

                    b.Navigation("Dorm");

                    b.Navigation("ParkingGarage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiningHall", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("api.Models.Dorm", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("api.Models.ParkingGarage", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("api.Models.User", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}

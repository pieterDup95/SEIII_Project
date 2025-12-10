using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace appointment_service.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "appointment_service",
                table: "appointment_request",
                columns: new[] { "id", "branch_id", "date", "reference_number", "time" },
                values: new object[,]
                {
                    { new Guid("0e53cfa9-0ec3-4fb8-9af4-1e05d90b4d77"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-712553", "15:00:00" },
                    { new Guid("11844cde-a827-4e74-8447-a1151e120284"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-375901", "16:00:00" },
                    { new Guid("1241d698-71dc-4f71-a81e-8bbbdff29a06"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-688973", "10:00:00" },
                    { new Guid("1669a651-6fd8-41c0-b4f1-a5c7b6e59f54"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-942453", "16:00:00" },
                    { new Guid("1b8fab20-8ed1-485d-983d-f7391f3b40d7"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-445258", "13:00:00" },
                    { new Guid("1bb8cff5-9633-41ee-8120-f2f8f9eabeea"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-701310", "14:00:00" },
                    { new Guid("1ebd2dbe-a240-41d8-aebf-ee5ff6e1b435"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-374886", "11:00:00" },
                    { new Guid("1fbb9e3d-8fd6-47d0-b915-18cf45dae62a"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-251753", "14:00:00" },
                    { new Guid("227f3299-8c09-458a-bd43-0df3f76ddc4d"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-915046", "14:00:00" },
                    { new Guid("2c8fe620-2381-4510-a4cd-aad8afb94a2a"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-130262", "17:00:00" },
                    { new Guid("2ccd40fc-0969-4f35-bb0a-e65b28113048"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-83846", "13:00:00" },
                    { new Guid("3733cdc8-61fa-41ea-ad4f-f007cbf7a879"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-677076", "13:00:00" },
                    { new Guid("3ff2feee-8c1a-405d-ab2a-9c2010bcb7e8"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-27569", "16:00:00" },
                    { new Guid("43a01695-779a-457d-8d7b-fbe71bac16df"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-379865", "10:00:00" },
                    { new Guid("48627704-5390-499b-9762-d56edf5f9e04"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-834140", "08:00:00" },
                    { new Guid("48a92726-8dfc-4d78-9296-351e5ddd205c"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-85013", "16:00:00" },
                    { new Guid("5da55e55-36e8-491b-a0d5-80e93f4a77a3"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-905698", "09:00:00" },
                    { new Guid("609da30e-2d50-4c30-a390-d8758011c902"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-51389", "09:00:00" },
                    { new Guid("65bc988e-1605-4988-b883-0716d9fc39a3"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-335958", "14:00:00" },
                    { new Guid("666e4e55-e310-4d6c-b0fa-a848670d1cac"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-132846", "12:00:00" },
                    { new Guid("728c801f-d62b-4f4f-a597-d8026d986e28"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-566716", "17:00:00" },
                    { new Guid("7b7a3b84-f4b8-41ee-88fd-2a0d2e510792"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-576998", "12:00:00" },
                    { new Guid("804e0de0-6d8b-47fb-ae37-e7d8c44894e8"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-10879", "09:00:00" },
                    { new Guid("835cc4bb-c7d5-4dc2-9113-5d52f5c1e192"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-162762", "16:00:00" },
                    { new Guid("8fd109d1-03bf-4fa1-b48c-9279fa52b11c"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-232864", "11:00:00" },
                    { new Guid("99083259-1ecf-4e79-b93f-93f5a33ca5c9"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-656308", "12:00:00" },
                    { new Guid("9a915f03-f765-4244-9494-260baa5f7342"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-856936", "14:00:00" },
                    { new Guid("9cb971d1-8e70-46b7-8990-bce9691a6672"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-442689", "11:00:00" },
                    { new Guid("9e353431-f110-4585-82c9-c246ccdea4a9"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-493807", "15:00:00" },
                    { new Guid("a37c7abe-31ed-4efe-a57f-e8f93b2833a1"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-451123", "17:00:00" },
                    { new Guid("a625215a-920f-4661-a173-b11ddbc368ed"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-725423", "11:00:00" },
                    { new Guid("a8af5dfc-ea32-4bdb-ae17-94f7c47ff7ae"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-840540", "15:00:00" },
                    { new Guid("ae0a6c5b-3c2f-4d87-874c-7cb5d24fe152"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-178721", "15:00:00" },
                    { new Guid("b6e135dd-3364-4146-9e1a-3b8a26667449"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-650817", "13:00:00" },
                    { new Guid("b8bd777d-050b-4f44-90fb-7feda3ee6f05"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-390021", "10:00:00" },
                    { new Guid("c557edb6-d97d-4059-8342-97555c2506b0"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-54228", "09:00:00" },
                    { new Guid("c611b265-97b4-499e-a593-a96b6777ab76"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-203757", "11:00:00" },
                    { new Guid("c6cb98dd-020e-4b7c-82e0-61f3dcab8607"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-339661", "16:00:00" },
                    { new Guid("cc8a0414-df78-47c3-ad11-3d0de0b6483e"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-995615", "09:00:00" },
                    { new Guid("cd4a4b2b-2070-4294-a776-1e8028d06c1f"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-760340", "13:00:00" },
                    { new Guid("d5f32150-a812-4adf-9715-72a390ae389c"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-915195", "11:00:00" },
                    { new Guid("d6fcf541-7bef-42de-a5f8-e9bb67a6f9b2"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-614228", "09:00:00" },
                    { new Guid("da14dafc-d7d2-43cc-a1ff-5cc92a8f3f38"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-117861", "14:00:00" },
                    { new Guid("daec19d7-9dbe-4e1f-bec2-638fa981a75d"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-60670", "10:00:00" },
                    { new Guid("db342e94-3f2b-4122-a1f6-9c4691acbd90"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-692239", "15:00:00" },
                    { new Guid("db5f2952-fce4-43d3-bd94-a3eae3732c00"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-812264", "13:00:00" },
                    { new Guid("e037a1be-8682-4bdd-a160-0dfd19c374d8"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-934908", "13:00:00" },
                    { new Guid("e0fd43bd-dd70-47e1-ab85-67c1a8b57622"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-747406", "16:00:00" },
                    { new Guid("e1931182-10c0-4c60-b259-3df6429a63c9"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-106190", "13:00:00" },
                    { new Guid("f0baefed-3b72-4bef-b43c-5c083ff94259"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-179180", "15:00:00" },
                    { new Guid("fc3f5c4a-fa85-4980-911d-2e328da62fc2"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-87379", "11:00:00" },
                    { new Guid("fc77fcef-6d6e-4374-9b75-4904c7688484"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB-501085", "09:00:00" }
                });

            migrationBuilder.InsertData(
                schema: "appointment_service",
                table: "branch",
                columns: new[] { "id", "address", "branch_code", "branch_name", "city", "contact_number", "provice", "slot_per_hour", "suburb" },
                values: new object[,]
                {
                    { new Guid("0d819742-cd02-467c-9116-210baf093806"), "Cnr R44 & N2, Somerset West", 50318, "Somerset Mall", "Somerset West", "021 852 1234", "Western Cape", 6, "Somerset West" },
                    { new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), "Willie van Schoor Avenue, Bellville", 50419, "Tyger Valley", "Bellville", "021 914 5678", "Western Cape", 6, "Bellville" },
                    { new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), "Cnr Modderfontein & Van Riebeeck Roads, Greenstone", 250945, "Greenstone Mall", "Johannesburg", "011 452 1234", "Gauteng", 5, "Edenvale" },
                    { new Guid("2786bf11-426a-4450-83e3-f0356c929273"), "50 Bath Avenue, Rosebank", 250601, "Rosebank Mall", "Johannesburg", "011 447 8900", "Gauteng", 5, "Rosebank" },
                    { new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), "Shop 6170, Victoria Wharf, V&A Waterfront", 50001, "V&A Waterfront", "Cape Town", "021 418 1234", "Western Cape", 7, "V&A Waterfront" },
                    { new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), "Corner Rivonia Road & 5th Street, Sandton City", 630218, "Sandton City", "Johannesburg", "011 783 1234", "Gauteng", 6, "Sandton" },
                    { new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), "43 Bradford Road, Bedfordview", 250801, "Eastgate Shopping Centre", "Johannesburg", "011 616 5678", "Gauteng", 5, "Bedfordview" },
                    { new Guid("5510587c-cda4-400b-92df-00940212c02d"), "115 Musgrave Road, Berea", 57645, "Musgrave Centre", "Durban", "031 201 5678", "KwaZulu-Natal", 5, "Berea" },
                    { new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), "30 Melrose Boulevard, Melrose Arch", 250719, "Melrose Arch", "Johannesburg", "011 684 1234", "Gauteng", 6, "Melrose" },
                    { new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), "Leonora Drive, Ballito", 57912, "Ballito Junction", "Ballito", "032 946 1234", "KwaZulu-Natal", 6, "Ballito" },
                    { new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), "333 Veale Street, Brooklyn", 460215, "Brooklyn Mall", "Pretoria", "012 346 7890", "Gauteng", 6, "Brooklyn" },
                    { new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), "Century Boulevard, Century City", 50217, "Canal Walk", "Cape Town", "021 555 5678", "Western Cape", 6, "Century City" },
                    { new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), "Jack Martens Drive, Dawncliffe", 57801, "The Pavilion Westville", "Durban", "031 275 1234", "KwaZulu-Natal", 6, "Westville" },
                    { new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), "William Nicol Drive & Fourways Boulevard", 250835, "Fourways Mall", "Johannesburg", "011 465 5678", "Gauteng", 5, "Fourways" },
                    { new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), "Cnr Atterbury Road & Lois Avenue, Menlyn", 460110, "Menlyn Park", "Pretoria", "012 471 1234", "Gauteng", 6, "Menlyn" },
                    { new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), "333 Veale Street, Nieuw Muckleneuk", 460215, "Brooklyn Mall", "Pretoria", "012 346 7890", "Gauteng", 5, "Brooklyn" },
                    { new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), "Jack Martens Drive, Westville", 57801, "Pavilion Mall", "Westville", "031 275 1234", "KwaZulu-Natal", 6, "Westville" },
                    { new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), "Main Road & Cavendish Street, Claremont", 50102, "Claremont", "Cape Town", "021 671 2345", "Western Cape", 5, "Claremont" },
                    { new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), "1 Palm Boulevard, Umhlanga Ridge", 57729, "Gateway Theatre of Shopping", "Durban", "031 566 8900", "KwaZulu-Natal", 7, "Umhlanga" },
                    { new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), "Beyers Naudé Drive, Cresta", 250501, "Cresta Shopping Centre", "Johannesburg", "011 478 5678", "Gauteng", 6, "Randburg" }
                });

            migrationBuilder.InsertData(
                schema: "appointment_service",
                table: "customer_info",
                columns: new[] { "appointment_request_id", "contact_number", "email", "full_name", "id_number", "notes" },
                values: new object[,]
                {
                    { new Guid("0e53cfa9-0ec3-4fb8-9af4-1e05d90b4d77"), "0763544510", "lindiwe.dlamini@example.com", "Lindiwe Dlamini", "8808137886000", "" },
                    { new Guid("11844cde-a827-4e74-8447-a1151e120284"), "0633424051", "anele.jacobs@example.com", "Anele Jacobs", "9601049905000", "Open new account" },
                    { new Guid("1241d698-71dc-4f71-a81e-8bbbdff29a06"), "0628179492", "kagiso.botha@example.com", "Kagiso Botha", "9311268300100", "" },
                    { new Guid("1669a651-6fd8-41c0-b4f1-a5c7b6e59f54"), "0744799925", "naledi.jacobs@example.com", "Naledi Jacobs", "7003081346000", "Home loan inquiry" },
                    { new Guid("1b8fab20-8ed1-485d-983d-f7391f3b40d7"), "0652925158", "zinhle.nkosi@example.com", "Zinhle Nkosi", "7506022114000", "" },
                    { new Guid("1bb8cff5-9633-41ee-8120-f2f8f9eabeea"), "0747043831", "lindiwe.mokoena@example.com", "Lindiwe Mokoena", "8301241382000", "" },
                    { new Guid("1ebd2dbe-a240-41d8-aebf-ee5ff6e1b435"), "0773030365", "tumelo.naidoo@example.com", "Tumelo Naidoo", "8609126891100", "" },
                    { new Guid("1fbb9e3d-8fd6-47d0-b915-18cf45dae62a"), "0687984993", "lindiwe.jacobs@example.com", "Lindiwe Jacobs", "7909051928000", "Open new account" },
                    { new Guid("227f3299-8c09-458a-bd43-0df3f76ddc4d"), "0808050648", "lerato.smith@example.com", "Lerato Smith", "9411028456000", "" },
                    { new Guid("2c8fe620-2381-4510-a4cd-aad8afb94a2a"), "0682398925", "sipho.botha@example.com", "Sipho Botha", "7812101005100", "Lost ID book" },
                    { new Guid("2ccd40fc-0969-4f35-bb0a-e65b28113048"), "0663056597", "naledi.naidoo@example.com", "Naledi Naidoo", "9403246979000", "" },
                    { new Guid("3733cdc8-61fa-41ea-ad4f-f007cbf7a879"), "0744523013", "lindiwe.dlamini@example.com", "Lindiwe Dlamini", "7807167411000", "" },
                    { new Guid("3ff2feee-8c1a-405d-ab2a-9c2010bcb7e8"), "0825611378", "lindiwe.van der merwe@example.com", "Lindiwe Van der Merwe", "9505039779000", "" },
                    { new Guid("43a01695-779a-457d-8d7b-fbe71bac16df"), "0631811013", "naledi.nkosi@example.com", "Naledi Nkosi", "8501226194000", "" },
                    { new Guid("48627704-5390-499b-9762-d56edf5f9e04"), "0648172358", "bongani.smith@example.com", "Bongani Smith", "7906204725000", "" },
                    { new Guid("48a92726-8dfc-4d78-9296-351e5ddd205c"), "0782803858", "zinhle.naidoo@example.com", "Zinhle Naidoo", "9102224130100", "" },
                    { new Guid("5da55e55-36e8-491b-a0d5-80e93f4a77a3"), "0712836970", "tumelo.pillay@example.com", "Tumelo Pillay", "8411128412000", "" },
                    { new Guid("609da30e-2d50-4c30-a390-d8758011c902"), "0635178724", "anele.pillay@example.com", "Anele Pillay", "7902067718000", "" },
                    { new Guid("65bc988e-1605-4988-b883-0716d9fc39a3"), "0781277808", "lindiwe.smith@example.com", "Lindiwe Smith", "9008273665100", "" },
                    { new Guid("666e4e55-e310-4d6c-b0fa-a848670d1cac"), "0668385494", "tumelo.jacobs@example.com", "Tumelo Jacobs", "9410129160000", "" },
                    { new Guid("728c801f-d62b-4f4f-a597-d8026d986e28"), "0622282467", "lindiwe.jacobs@example.com", "Lindiwe Jacobs", "8004084685100", "" },
                    { new Guid("7b7a3b84-f4b8-41ee-88fd-2a0d2e510792"), "0838401009", "bongani.jacobs@example.com", "Bongani Jacobs", "9603105879100", "" },
                    { new Guid("804e0de0-6d8b-47fb-ae37-e7d8c44894e8"), "0776656172", "zinhle.dlamini@example.com", "Zinhle Dlamini", "7108141457000", "Open new account" },
                    { new Guid("835cc4bb-c7d5-4dc2-9113-5d52f5c1e192"), "0636644896", "sipho.dlamini@example.com", "Sipho Dlamini", "8407105215100", "" },
                    { new Guid("8fd109d1-03bf-4fa1-b48c-9279fa52b11c"), "0761847081", "anele.dlamini@example.com", "Anele Dlamini", "9304151451000", "" },
                    { new Guid("99083259-1ecf-4e79-b93f-93f5a33ca5c9"), "0611981501", "bongani.botha@example.com", "Bongani Botha", "8908235544000", "" },
                    { new Guid("9a915f03-f765-4244-9494-260baa5f7342"), "0796638106", "anele.botha@example.com", "Anele Botha", "9205051237000", "Open new account" },
                    { new Guid("9cb971d1-8e70-46b7-8990-bce9691a6672"), "0649442577", "kagiso.govender@example.com", "Kagiso Govender", "8912108708000", "" },
                    { new Guid("9e353431-f110-4585-82c9-c246ccdea4a9"), "0719310014", "sipho.pillay@example.com", "Sipho Pillay", "9101103026100", "Open new account" },
                    { new Guid("a37c7abe-31ed-4efe-a57f-e8f93b2833a1"), "0826106156", "sipho.pillay@example.com", "Sipho Pillay", "8806035581100", "" },
                    { new Guid("a625215a-920f-4661-a173-b11ddbc368ed"), "0835150743", "lindiwe.mokoena@example.com", "Lindiwe Mokoena", "7001181310100", "" },
                    { new Guid("a8af5dfc-ea32-4bdb-ae17-94f7c47ff7ae"), "0704781399", "anele.govender@example.com", "Anele Govender", "8312148734000", "Lost ID book" },
                    { new Guid("ae0a6c5b-3c2f-4d87-874c-7cb5d24fe152"), "0829722729", "kagiso.botha@example.com", "Kagiso Botha", "9610269486000", "Lost ID book" },
                    { new Guid("b6e135dd-3364-4146-9e1a-3b8a26667449"), "0821148509", "bongani.mokoena@example.com", "Bongani Mokoena", "8411099273100", "Lost ID book" },
                    { new Guid("b8bd777d-050b-4f44-90fb-7feda3ee6f05"), "0705621465", "lerato.mokoena@example.com", "Lerato Mokoena", "9101131108100", "" },
                    { new Guid("c557edb6-d97d-4059-8342-97555c2506b0"), "0793111295", "sipho.naidoo@example.com", "Sipho Naidoo", "7504205615000", "Lost ID book" },
                    { new Guid("c611b265-97b4-499e-a593-a96b6777ab76"), "0753363498", "lerato.govender@example.com", "Lerato Govender", "8107139868000", "" },
                    { new Guid("c6cb98dd-020e-4b7c-82e0-61f3dcab8607"), "0753897194", "zinhle.naidoo@example.com", "Zinhle Naidoo", "8005066445100", "" },
                    { new Guid("cc8a0414-df78-47c3-ad11-3d0de0b6483e"), "0819063051", "sipho.van der merwe@example.com", "Sipho Van der Merwe", "7910231081000", "Home loan inquiry" },
                    { new Guid("cd4a4b2b-2070-4294-a776-1e8028d06c1f"), "0676248441", "tumelo.dlamini@example.com", "Tumelo Dlamini", "9709142677000", "" },
                    { new Guid("d5f32150-a812-4adf-9715-72a390ae389c"), "0803083444", "bongani.nkosi@example.com", "Bongani Nkosi", "8702258679000", "" },
                    { new Guid("d6fcf541-7bef-42de-a5f8-e9bb67a6f9b2"), "0659249657", "naledi.dlamini@example.com", "Naledi Dlamini", "8102016875000", "" },
                    { new Guid("da14dafc-d7d2-43cc-a1ff-5cc92a8f3f38"), "0654740836", "kagiso.govender@example.com", "Kagiso Govender", "8402049784000", "" },
                    { new Guid("daec19d7-9dbe-4e1f-bec2-638fa981a75d"), "0668938556", "bongani.mokoena@example.com", "Bongani Mokoena", "7103092543000", "" },
                    { new Guid("db342e94-3f2b-4122-a1f6-9c4691acbd90"), "0602636691", "bongani.smith@example.com", "Bongani Smith", "8612222154000", "" },
                    { new Guid("db5f2952-fce4-43d3-bd94-a3eae3732c00"), "0822732011", "thabo.mokoena@example.com", "Thabo Mokoena", "7712171860100", "" },
                    { new Guid("e037a1be-8682-4bdd-a160-0dfd19c374d8"), "0826280649", "naledi.dlamini@example.com", "Naledi Dlamini", "8310154605000", "" },
                    { new Guid("e0fd43bd-dd70-47e1-ab85-67c1a8b57622"), "0758589714", "thabo.smith@example.com", "Thabo Smith", "8412273345100", "Open new account" },
                    { new Guid("e1931182-10c0-4c60-b259-3df6429a63c9"), "0838935052", "bongani.smith@example.com", "Bongani Smith", "8807023550100", "" },
                    { new Guid("f0baefed-3b72-4bef-b43c-5c083ff94259"), "0739908456", "anele.naidoo@example.com", "Anele Naidoo", "9910197433000", "" },
                    { new Guid("fc3f5c4a-fa85-4980-911d-2e328da62fc2"), "0659401153", "anele.pillay@example.com", "Anele Pillay", "8803092647000", "" },
                    { new Guid("fc77fcef-6d6e-4374-9b75-4904c7688484"), "0686537892", "bongani.dlamini@example.com", "Bongani Dlamini", "8903186871100", "" }
                });

            migrationBuilder.InsertData(
                schema: "appointment_service",
                table: "operational_hours",
                columns: new[] { "id", "branch_id", "close_time", "day_of_week", "open_time" },
                values: new object[,]
                {
                    { new Guid("02f299b2-138c-4672-bfc1-838f290e3ccf"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("03112b3b-b929-4795-896c-f657dd731689"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("04cadbd3-eb2b-49ac-877c-344719cca005"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("05609ce2-06c4-4bd2-98a0-5297bf7b7d52"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("0698231c-d0f1-4fae-a2ac-0d98a1460e1b"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("0df97a32-39cf-42ab-9894-8bf25558c335"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("11f4965f-89f5-4aa4-b9de-d1d8011ec84e"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("146bf479-7132-437c-857b-53c0a552ec11"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("1727b65d-9218-4d8c-bb4d-61037991b201"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 19, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("19c2072c-7e03-496d-9847-489437012b3a"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("1cc97b43-2684-4ffd-b92a-05db1d032f02"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("208a8ca4-1a34-40e6-aced-90f11aa4db88"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("234810a4-e95f-4f7a-a9b3-8b5b375aa663"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("279bf6ac-bcf5-43b0-a81a-f8074a93bd73"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("2d1f423e-d88e-4174-a4bf-b15790415b10"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("304ed6f7-6392-423c-9d9a-a63b51308062"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("3108b97a-7a62-4781-a469-d912d92017d5"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("35398eb8-25b9-4ceb-80f0-72ee51ad6841"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("3654c072-59f3-4c7a-b72b-029c7a49b9e5"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("3658eacd-bd13-4523-9c29-f3f29a63f7dd"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("37231caf-8d95-4cfd-bc75-81eb7470f6d9"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("37424ac6-4a38-435f-830d-8575f8d4463c"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("38d515a2-c90c-44c4-a63b-096913256f1e"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 19, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("3a3ed808-5729-474c-a223-1aec225e363e"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("3bb5a292-8764-4af5-b252-639910541a18"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("3cfe9217-1b83-44c3-bd83-51b808d9e380"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("4029ba95-8614-4bb7-83a9-6812f6e4f1d4"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("4055417c-c02b-4df3-9418-4425511a158c"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("41904113-5745-442f-a31c-9fa7690e6048"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("4313dbb5-b974-493d-b30e-99e904f755f4"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("4613069d-9c9c-4401-861a-e0ee04995046"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("47d52879-b762-4741-89b1-560c4d4de3fe"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("48695143-527e-4f79-a3dd-0f0220f76bbe"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("48ce56ee-5771-442e-b5df-8455942216f2"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("4cd4e94d-6b2e-47f0-b97d-60997263032b"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("4d17152e-606b-4419-a45b-609d42d32936"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("4ef8c936-f55b-4809-9113-78bb9d2fef77"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("5081ae32-c46f-40d5-92ee-be41d804aab1"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("518856b8-be99-42a9-97c4-eacaf737980d"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 19, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("5274c141-aced-449d-8ef5-6c7824a1dec6"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("53e5c778-f1b4-4772-8fa8-cba1c8b94866"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("5a647449-7fa6-46a3-b84b-257319e17784"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("628334a8-dbd0-4be8-acd5-3dd5c50a8528"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("633cb047-516e-4413-a615-35efc8e5ff73"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("6411f9ba-0f58-4dcc-a7c4-a5ddb77453f6"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("6b126d6f-2cdf-42c3-b205-c8e12885305e"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("6b4a548a-40b5-4306-8c35-b0f448a020e3"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("6c29d94b-caea-4afe-ba59-6558c750bc8b"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("6c3c9e4e-c2d1-4ce2-a752-d257f057d593"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("6e330e8b-5563-45e6-8f40-3af706c5fcaf"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("6f438051-d0e2-46c5-9b33-0b4858d27ff2"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("715503d5-e432-4768-bb3c-5517ea39ea4d"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("7206ed45-ea53-42f7-9532-337ff9f692fb"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("728cbaeb-9c53-47f0-88fa-765a12e1b70e"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("76ec7fa7-10aa-43bc-b705-49e0dde4a5a5"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("7b996af7-53fd-4e8e-a240-f7ad80419260"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("7f143afa-3852-4d5f-acdd-650e50240b92"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("88a33048-5e38-46c5-ab9d-8748b225fab2"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("8bc2db03-8b7e-48cb-a2ad-dd943f1f9c54"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("8bd53abb-6929-4889-a78b-12c66f7b36d5"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("8ca2a5a2-68d5-4418-9ed9-585dbe9141e3"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("8dc08b10-9e46-43a4-9c99-9e686f193938"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("8f86f7df-a870-4bd0-ba15-dbf913a6e829"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("927fd25f-78dd-4adf-bdcf-4a284081be7d"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("92b70862-0fe7-46b9-aae8-7bbd57dc3d93"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("974a340c-bdd1-428b-8ded-f83fa43d5f52"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("98dd7454-b96c-4ec2-9fa6-82f6735f4e96"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("997a77c3-eaa7-49aa-8f78-033853f2fb39"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 19, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("9a5a1b8f-7c23-445b-82ed-97be262ff330"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("9af7e315-b778-4f43-b942-7bc1b625a09f"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("9d2e3d7b-fe8f-4712-a4f6-f0d9415eb00c"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("9f0792e3-c74e-483f-8301-a6acdfbd778b"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 19, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("a15916ea-7bfa-4621-89c7-d6ea6cf8d224"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("a3d0d19a-3d05-4305-a71d-7b1036aeb6c3"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("a3ea146b-9ee4-43b4-ada0-38292011bdd2"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("a6db1ddc-911d-4701-83c5-ad2803a98599"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("a6ecbec2-319d-4f3f-b725-aaa9f6f0bf46"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("a702d76a-6b6d-49e2-a5af-d5df0068187e"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("a75afb18-4c30-4dcb-b4c3-171bc9ec8c9a"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("a8d8a072-299d-4558-b97f-9d281dbe399f"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("ac123fe9-56d2-4a6d-926f-c67fe8a9309d"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("b2528273-0967-4106-bfec-5355c69ffb02"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("b27022c9-a4f2-4df2-a6e8-bf9fec64041f"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("b38d1a87-ecca-4c9e-bdf8-950211acc580"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("ba7b505c-8562-4366-acd3-ed65f693119e"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("ba8af074-0e6a-4776-aa30-d9c9aeb5f8ae"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("bc968d41-cedd-464a-b6fb-61443eafc029"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("be570dc4-3fcd-4564-a360-36d82d1d3f29"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c20ce275-f4ad-454a-bfd2-5759753ee720"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c494de6e-7bed-43c1-bc69-9f32ae36f483"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c4dfb05a-9170-48ae-9850-1afbb91b8d2d"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c7584c1f-18db-43a5-a0b5-9f996c983198"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("caf0f294-c809-4e01-9195-c13b4d032c23"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("cdc9b75e-1cf2-4b99-8554-a629e5782c4a"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("d1813d05-4da0-48c2-939d-4b884a29d6b2"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("d5f19ec5-f0ae-47fd-ad4d-e36a284c72c5"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("d61033c3-cca3-4c5d-a5dd-69cac97b1839"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("d9bfedc5-2c2c-4317-b5af-340ba8cc83a0"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("daea8f41-83e3-40d3-b275-60bcd7f34851"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("dba50cef-12dc-4904-91d0-f75bdbddc666"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("dc4fce2d-0b5d-4903-a6cd-b870579cca6a"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("dda96ace-6ca3-4f06-81bb-dbb0c6510b4b"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("de922752-87ac-417b-9322-453c743cc551"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 19, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("decc44e2-db91-4268-847b-0fd594ece608"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("e0b2290c-6c05-47f3-bbf4-f3403c1a8d8f"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("e1dd9b7d-a68e-4376-835c-ede2114e6c8e"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("e34a01dc-c09c-44d3-ac4d-6457bea41368"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("e5a201f0-633d-4a03-a72a-2c77dabc8d47"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("e8eb2273-7214-4004-820c-1acfbc8c75f5"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("e9ab68cc-a1ce-4ae4-adc4-a02c7ad319dc"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("ec9abdb4-cfa0-4bfc-b46a-1b3cbe1929de"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("ed9eb53b-67ec-4352-99d3-e8c18f49a340"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("f62f98cf-9ec7-4acc-8e01-d5b0c6c0bcd3"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("f652ee94-e66f-453d-9f0c-87c4f137ccc3"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("f96fdc87-8183-4fc5-adbe-9ba1acaa6338"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("fc8923c2-03c4-4878-ad5a-68e4625be15b"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("fcc15488-f79f-409c-ba26-45bfacc3e3bd"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("fe0beb13-f8d8-4466-8f46-d10a22b3a88c"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("fe39f80d-02d6-43f3-a052-cb195c85f19f"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0e53cfa9-0ec3-4fb8-9af4-1e05d90b4d77"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("11844cde-a827-4e74-8447-a1151e120284"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1241d698-71dc-4f71-a81e-8bbbdff29a06"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1669a651-6fd8-41c0-b4f1-a5c7b6e59f54"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1b8fab20-8ed1-485d-983d-f7391f3b40d7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1bb8cff5-9633-41ee-8120-f2f8f9eabeea"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1ebd2dbe-a240-41d8-aebf-ee5ff6e1b435"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1fbb9e3d-8fd6-47d0-b915-18cf45dae62a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("227f3299-8c09-458a-bd43-0df3f76ddc4d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2c8fe620-2381-4510-a4cd-aad8afb94a2a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2ccd40fc-0969-4f35-bb0a-e65b28113048"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("3733cdc8-61fa-41ea-ad4f-f007cbf7a879"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("3ff2feee-8c1a-405d-ab2a-9c2010bcb7e8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("43a01695-779a-457d-8d7b-fbe71bac16df"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("48627704-5390-499b-9762-d56edf5f9e04"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("48a92726-8dfc-4d78-9296-351e5ddd205c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5da55e55-36e8-491b-a0d5-80e93f4a77a3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("609da30e-2d50-4c30-a390-d8758011c902"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("65bc988e-1605-4988-b883-0716d9fc39a3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("666e4e55-e310-4d6c-b0fa-a848670d1cac"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("728c801f-d62b-4f4f-a597-d8026d986e28"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("7b7a3b84-f4b8-41ee-88fd-2a0d2e510792"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("804e0de0-6d8b-47fb-ae37-e7d8c44894e8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("835cc4bb-c7d5-4dc2-9113-5d52f5c1e192"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("8fd109d1-03bf-4fa1-b48c-9279fa52b11c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("99083259-1ecf-4e79-b93f-93f5a33ca5c9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9a915f03-f765-4244-9494-260baa5f7342"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9cb971d1-8e70-46b7-8990-bce9691a6672"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9e353431-f110-4585-82c9-c246ccdea4a9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a37c7abe-31ed-4efe-a57f-e8f93b2833a1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a625215a-920f-4661-a173-b11ddbc368ed"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a8af5dfc-ea32-4bdb-ae17-94f7c47ff7ae"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ae0a6c5b-3c2f-4d87-874c-7cb5d24fe152"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b6e135dd-3364-4146-9e1a-3b8a26667449"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b8bd777d-050b-4f44-90fb-7feda3ee6f05"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c557edb6-d97d-4059-8342-97555c2506b0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c611b265-97b4-499e-a593-a96b6777ab76"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c6cb98dd-020e-4b7c-82e0-61f3dcab8607"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("cc8a0414-df78-47c3-ad11-3d0de0b6483e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("cd4a4b2b-2070-4294-a776-1e8028d06c1f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d5f32150-a812-4adf-9715-72a390ae389c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d6fcf541-7bef-42de-a5f8-e9bb67a6f9b2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("da14dafc-d7d2-43cc-a1ff-5cc92a8f3f38"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("daec19d7-9dbe-4e1f-bec2-638fa981a75d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("db342e94-3f2b-4122-a1f6-9c4691acbd90"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("db5f2952-fce4-43d3-bd94-a3eae3732c00"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e037a1be-8682-4bdd-a160-0dfd19c374d8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e0fd43bd-dd70-47e1-ab85-67c1a8b57622"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e1931182-10c0-4c60-b259-3df6429a63c9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f0baefed-3b72-4bef-b43c-5c083ff94259"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fc3f5c4a-fa85-4980-911d-2e328da62fc2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fc77fcef-6d6e-4374-9b75-4904c7688484"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("02f299b2-138c-4672-bfc1-838f290e3ccf"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("03112b3b-b929-4795-896c-f657dd731689"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("04cadbd3-eb2b-49ac-877c-344719cca005"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("05609ce2-06c4-4bd2-98a0-5297bf7b7d52"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("0698231c-d0f1-4fae-a2ac-0d98a1460e1b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("0df97a32-39cf-42ab-9894-8bf25558c335"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("11f4965f-89f5-4aa4-b9de-d1d8011ec84e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("146bf479-7132-437c-857b-53c0a552ec11"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("1727b65d-9218-4d8c-bb4d-61037991b201"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("19c2072c-7e03-496d-9847-489437012b3a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("1cc97b43-2684-4ffd-b92a-05db1d032f02"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("208a8ca4-1a34-40e6-aced-90f11aa4db88"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("234810a4-e95f-4f7a-a9b3-8b5b375aa663"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("279bf6ac-bcf5-43b0-a81a-f8074a93bd73"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("2d1f423e-d88e-4174-a4bf-b15790415b10"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("304ed6f7-6392-423c-9d9a-a63b51308062"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("3108b97a-7a62-4781-a469-d912d92017d5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("35398eb8-25b9-4ceb-80f0-72ee51ad6841"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("3654c072-59f3-4c7a-b72b-029c7a49b9e5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("3658eacd-bd13-4523-9c29-f3f29a63f7dd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("37231caf-8d95-4cfd-bc75-81eb7470f6d9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("37424ac6-4a38-435f-830d-8575f8d4463c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("38d515a2-c90c-44c4-a63b-096913256f1e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("3a3ed808-5729-474c-a223-1aec225e363e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("3bb5a292-8764-4af5-b252-639910541a18"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("3cfe9217-1b83-44c3-bd83-51b808d9e380"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("4029ba95-8614-4bb7-83a9-6812f6e4f1d4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("4055417c-c02b-4df3-9418-4425511a158c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("41904113-5745-442f-a31c-9fa7690e6048"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("4313dbb5-b974-493d-b30e-99e904f755f4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("4613069d-9c9c-4401-861a-e0ee04995046"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("47d52879-b762-4741-89b1-560c4d4de3fe"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("48695143-527e-4f79-a3dd-0f0220f76bbe"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("48ce56ee-5771-442e-b5df-8455942216f2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("4cd4e94d-6b2e-47f0-b97d-60997263032b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("4d17152e-606b-4419-a45b-609d42d32936"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("4ef8c936-f55b-4809-9113-78bb9d2fef77"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("5081ae32-c46f-40d5-92ee-be41d804aab1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("518856b8-be99-42a9-97c4-eacaf737980d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("5274c141-aced-449d-8ef5-6c7824a1dec6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("53e5c778-f1b4-4772-8fa8-cba1c8b94866"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("5a647449-7fa6-46a3-b84b-257319e17784"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("628334a8-dbd0-4be8-acd5-3dd5c50a8528"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("633cb047-516e-4413-a615-35efc8e5ff73"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6411f9ba-0f58-4dcc-a7c4-a5ddb77453f6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6b126d6f-2cdf-42c3-b205-c8e12885305e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6b4a548a-40b5-4306-8c35-b0f448a020e3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6c29d94b-caea-4afe-ba59-6558c750bc8b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6c3c9e4e-c2d1-4ce2-a752-d257f057d593"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6e330e8b-5563-45e6-8f40-3af706c5fcaf"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6f438051-d0e2-46c5-9b33-0b4858d27ff2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("715503d5-e432-4768-bb3c-5517ea39ea4d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("7206ed45-ea53-42f7-9532-337ff9f692fb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("728cbaeb-9c53-47f0-88fa-765a12e1b70e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("76ec7fa7-10aa-43bc-b705-49e0dde4a5a5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("7b996af7-53fd-4e8e-a240-f7ad80419260"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("7f143afa-3852-4d5f-acdd-650e50240b92"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("88a33048-5e38-46c5-ab9d-8748b225fab2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8bc2db03-8b7e-48cb-a2ad-dd943f1f9c54"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8bd53abb-6929-4889-a78b-12c66f7b36d5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8ca2a5a2-68d5-4418-9ed9-585dbe9141e3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8dc08b10-9e46-43a4-9c99-9e686f193938"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8f86f7df-a870-4bd0-ba15-dbf913a6e829"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("927fd25f-78dd-4adf-bdcf-4a284081be7d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("92b70862-0fe7-46b9-aae8-7bbd57dc3d93"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("974a340c-bdd1-428b-8ded-f83fa43d5f52"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("98dd7454-b96c-4ec2-9fa6-82f6735f4e96"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("997a77c3-eaa7-49aa-8f78-033853f2fb39"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("9a5a1b8f-7c23-445b-82ed-97be262ff330"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("9af7e315-b778-4f43-b942-7bc1b625a09f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("9d2e3d7b-fe8f-4712-a4f6-f0d9415eb00c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("9f0792e3-c74e-483f-8301-a6acdfbd778b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a15916ea-7bfa-4621-89c7-d6ea6cf8d224"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a3d0d19a-3d05-4305-a71d-7b1036aeb6c3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a3ea146b-9ee4-43b4-ada0-38292011bdd2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a6db1ddc-911d-4701-83c5-ad2803a98599"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a6ecbec2-319d-4f3f-b725-aaa9f6f0bf46"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a702d76a-6b6d-49e2-a5af-d5df0068187e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a75afb18-4c30-4dcb-b4c3-171bc9ec8c9a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a8d8a072-299d-4558-b97f-9d281dbe399f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("ac123fe9-56d2-4a6d-926f-c67fe8a9309d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("b2528273-0967-4106-bfec-5355c69ffb02"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("b27022c9-a4f2-4df2-a6e8-bf9fec64041f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("b38d1a87-ecca-4c9e-bdf8-950211acc580"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("ba7b505c-8562-4366-acd3-ed65f693119e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("ba8af074-0e6a-4776-aa30-d9c9aeb5f8ae"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("bc968d41-cedd-464a-b6fb-61443eafc029"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("be570dc4-3fcd-4564-a360-36d82d1d3f29"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c20ce275-f4ad-454a-bfd2-5759753ee720"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c494de6e-7bed-43c1-bc69-9f32ae36f483"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c4dfb05a-9170-48ae-9850-1afbb91b8d2d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c7584c1f-18db-43a5-a0b5-9f996c983198"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("caf0f294-c809-4e01-9195-c13b4d032c23"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("cdc9b75e-1cf2-4b99-8554-a629e5782c4a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("d1813d05-4da0-48c2-939d-4b884a29d6b2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("d5f19ec5-f0ae-47fd-ad4d-e36a284c72c5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("d61033c3-cca3-4c5d-a5dd-69cac97b1839"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("d9bfedc5-2c2c-4317-b5af-340ba8cc83a0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("daea8f41-83e3-40d3-b275-60bcd7f34851"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("dba50cef-12dc-4904-91d0-f75bdbddc666"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("dc4fce2d-0b5d-4903-a6cd-b870579cca6a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("dda96ace-6ca3-4f06-81bb-dbb0c6510b4b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("de922752-87ac-417b-9322-453c743cc551"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("decc44e2-db91-4268-847b-0fd594ece608"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e0b2290c-6c05-47f3-bbf4-f3403c1a8d8f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e1dd9b7d-a68e-4376-835c-ede2114e6c8e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e34a01dc-c09c-44d3-ac4d-6457bea41368"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e5a201f0-633d-4a03-a72a-2c77dabc8d47"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e8eb2273-7214-4004-820c-1acfbc8c75f5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e9ab68cc-a1ce-4ae4-adc4-a02c7ad319dc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("ec9abdb4-cfa0-4bfc-b46a-1b3cbe1929de"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("ed9eb53b-67ec-4352-99d3-e8c18f49a340"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("f62f98cf-9ec7-4acc-8e01-d5b0c6c0bcd3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("f652ee94-e66f-453d-9f0c-87c4f137ccc3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("f96fdc87-8183-4fc5-adbe-9ba1acaa6338"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("fc8923c2-03c4-4878-ad5a-68e4625be15b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("fcc15488-f79f-409c-ba26-45bfacc3e3bd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("fe0beb13-f8d8-4466-8f46-d10a22b3a88c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("fe39f80d-02d6-43f3-a052-cb195c85f19f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0e53cfa9-0ec3-4fb8-9af4-1e05d90b4d77"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("11844cde-a827-4e74-8447-a1151e120284"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1241d698-71dc-4f71-a81e-8bbbdff29a06"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1669a651-6fd8-41c0-b4f1-a5c7b6e59f54"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1b8fab20-8ed1-485d-983d-f7391f3b40d7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1bb8cff5-9633-41ee-8120-f2f8f9eabeea"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1ebd2dbe-a240-41d8-aebf-ee5ff6e1b435"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1fbb9e3d-8fd6-47d0-b915-18cf45dae62a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("227f3299-8c09-458a-bd43-0df3f76ddc4d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2c8fe620-2381-4510-a4cd-aad8afb94a2a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2ccd40fc-0969-4f35-bb0a-e65b28113048"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("3733cdc8-61fa-41ea-ad4f-f007cbf7a879"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("3ff2feee-8c1a-405d-ab2a-9c2010bcb7e8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("43a01695-779a-457d-8d7b-fbe71bac16df"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("48627704-5390-499b-9762-d56edf5f9e04"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("48a92726-8dfc-4d78-9296-351e5ddd205c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5da55e55-36e8-491b-a0d5-80e93f4a77a3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("609da30e-2d50-4c30-a390-d8758011c902"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("65bc988e-1605-4988-b883-0716d9fc39a3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("666e4e55-e310-4d6c-b0fa-a848670d1cac"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("728c801f-d62b-4f4f-a597-d8026d986e28"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("7b7a3b84-f4b8-41ee-88fd-2a0d2e510792"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("804e0de0-6d8b-47fb-ae37-e7d8c44894e8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("835cc4bb-c7d5-4dc2-9113-5d52f5c1e192"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("8fd109d1-03bf-4fa1-b48c-9279fa52b11c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("99083259-1ecf-4e79-b93f-93f5a33ca5c9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9a915f03-f765-4244-9494-260baa5f7342"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9cb971d1-8e70-46b7-8990-bce9691a6672"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9e353431-f110-4585-82c9-c246ccdea4a9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a37c7abe-31ed-4efe-a57f-e8f93b2833a1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a625215a-920f-4661-a173-b11ddbc368ed"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a8af5dfc-ea32-4bdb-ae17-94f7c47ff7ae"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ae0a6c5b-3c2f-4d87-874c-7cb5d24fe152"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b6e135dd-3364-4146-9e1a-3b8a26667449"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b8bd777d-050b-4f44-90fb-7feda3ee6f05"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c557edb6-d97d-4059-8342-97555c2506b0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c611b265-97b4-499e-a593-a96b6777ab76"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c6cb98dd-020e-4b7c-82e0-61f3dcab8607"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("cc8a0414-df78-47c3-ad11-3d0de0b6483e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("cd4a4b2b-2070-4294-a776-1e8028d06c1f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d5f32150-a812-4adf-9715-72a390ae389c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d6fcf541-7bef-42de-a5f8-e9bb67a6f9b2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("da14dafc-d7d2-43cc-a1ff-5cc92a8f3f38"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("daec19d7-9dbe-4e1f-bec2-638fa981a75d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("db342e94-3f2b-4122-a1f6-9c4691acbd90"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("db5f2952-fce4-43d3-bd94-a3eae3732c00"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e037a1be-8682-4bdd-a160-0dfd19c374d8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e0fd43bd-dd70-47e1-ab85-67c1a8b57622"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e1931182-10c0-4c60-b259-3df6429a63c9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f0baefed-3b72-4bef-b43c-5c083ff94259"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fc3f5c4a-fa85-4980-911d-2e328da62fc2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fc77fcef-6d6e-4374-9b75-4904c7688484"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("0d819742-cd02-467c-9116-210baf093806"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("2786bf11-426a-4450-83e3-f0356c929273"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("5510587c-cda4-400b-92df-00940212c02d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"));
        }
    }
}

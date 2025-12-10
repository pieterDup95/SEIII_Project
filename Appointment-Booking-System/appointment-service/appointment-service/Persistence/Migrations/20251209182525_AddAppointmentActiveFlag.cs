using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace appointment_service.Migrations
{
    /// <inheritdoc />
    public partial class AddAppointmentActiveFlag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "active",
                schema: "appointment_service",
                table: "appointment_request",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                schema: "appointment_service",
                table: "appointment_request",
                columns: new[] { "id", "active", "branch_id", "date", "reference_number", "time" },
                values: new object[,]
                {
                    { new Guid("000a889f-9ffd-451e-8400-54d3969db426"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-151056", "16:00:00" },
                    { new Guid("03ce31f1-7ca5-4aec-830b-7795127c6ea4"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-147589", "13:00:00" },
                    { new Guid("03e2c7d3-7386-4368-bbc4-e471254b6780"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-794933", "11:00:00" },
                    { new Guid("04ce35c7-c4eb-4342-8d6b-f1f0344c2370"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-85995", "09:00:00" },
                    { new Guid("059402a7-00b0-46c8-9041-33d412389870"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-211371", "11:00:00" },
                    { new Guid("073c0b66-5a14-43f1-bfaa-4e0a26d5ea8d"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-516885", "16:00:00" },
                    { new Guid("074197db-c049-49ad-be52-3f07506f18df"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-53828", "16:00:00" },
                    { new Guid("07d787f0-e3ea-4d7b-b16c-8af4e447c65f"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-393329", "15:00:00" },
                    { new Guid("087224d2-7917-4698-ba6a-7e3a8dd0e63b"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-930546", "12:00:00" },
                    { new Guid("09afc615-7181-4e5d-9453-ed0d752d405e"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-821813", "09:00:00" },
                    { new Guid("0a444997-c7c2-4670-9d67-e4b3826aa62d"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-985078", "10:00:00" },
                    { new Guid("0a8c1911-3d41-4df4-a5a7-b9dc56a427b3"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-172067", "10:00:00" },
                    { new Guid("0baa0ab2-df95-497c-a179-95c5a914a627"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-557841", "10:00:00" },
                    { new Guid("0bd2c81d-337d-4698-957b-144f9ed9c694"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-400533", "10:00:00" },
                    { new Guid("0c5566d9-9f23-4e12-9df9-f8b8c7d1b3cd"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-586976", "10:00:00" },
                    { new Guid("0c706b02-daa0-4f0e-9d0f-8b2ce17e4bc3"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-784930", "13:00:00" },
                    { new Guid("0d6a4701-dde9-4fdb-b96b-865833d46422"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-973154", "14:00:00" },
                    { new Guid("0d7bdb2f-34c0-4619-893d-06a48cd95f73"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-851926", "14:00:00" },
                    { new Guid("0d983d2d-9b6f-49f4-a8e6-250ec962f3f0"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-206685", "11:00:00" },
                    { new Guid("0def0d56-139b-4735-b4e1-e81e208263cf"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-158311", "09:00:00" },
                    { new Guid("0fd5db95-91f3-44ef-a197-ce384f99ee7f"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-48072", "10:00:00" },
                    { new Guid("121a3289-9fb9-4100-9e65-40010cedc888"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-956318", "11:00:00" },
                    { new Guid("12f01143-f456-46a8-91d5-0ed1c49bbb54"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-953280", "12:00:00" },
                    { new Guid("14a83535-88ed-4f92-a8a4-b0505e876ab7"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 14, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-130130", "13:00:00" },
                    { new Guid("14c70f49-0213-4f62-b1ed-de30aedddbc4"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-453051", "17:00:00" },
                    { new Guid("180f0959-cd56-4dc6-a6b0-8878d6b313df"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-456001", "13:00:00" },
                    { new Guid("1868b44e-f17a-414f-a252-da5f387aaed7"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 27, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-61586", "09:00:00" },
                    { new Guid("18ffa0b5-bb47-4651-a999-bd5d35d28bf2"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-676178", "14:00:00" },
                    { new Guid("19bc264b-3cf1-4c57-ae01-c80a525e510f"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-666118", "13:00:00" },
                    { new Guid("19fe168a-0c50-4bc1-b1b7-a6226658f995"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-630643", "16:00:00" },
                    { new Guid("1a816255-847b-478b-b8d3-0e81754e8c84"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 13, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-339619", "12:00:00" },
                    { new Guid("1b2b5ed2-c08e-432a-a042-71df0045e35f"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-415428", "13:00:00" },
                    { new Guid("1b517727-c4c5-44e5-af23-754f5466bb8d"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-885991", "17:00:00" },
                    { new Guid("1b58344b-508f-4ff4-846d-ff22e50781c8"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-529947", "09:00:00" },
                    { new Guid("1b58f02f-124a-4c29-94f6-ad46a9012f1f"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-811736", "12:00:00" },
                    { new Guid("1b7e092a-e425-4660-b01b-50513e1606fb"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-218879", "12:00:00" },
                    { new Guid("1c34c833-bb5f-4045-809e-b0724a8418c9"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-182042", "15:00:00" },
                    { new Guid("1c4d6367-a2d8-45dc-8b39-176f24629b2b"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-479248", "09:00:00" },
                    { new Guid("1da7f0c2-6bb2-4dc4-9217-1291f1555381"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-25619", "09:00:00" },
                    { new Guid("1e52fde9-090d-458f-9fe4-4be040784c69"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-438405", "14:00:00" },
                    { new Guid("2059e01d-de89-4a86-850b-ff78b585a4ed"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-81244", "11:00:00" },
                    { new Guid("21112705-9235-4bfb-8de5-ebaf1ce5acb5"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-432417", "16:00:00" },
                    { new Guid("2114b709-1564-445d-a5ca-ca7b217ad380"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 14, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-919447", "11:00:00" },
                    { new Guid("22761405-93ce-4ea1-9dfe-8de6b52829f6"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-932387", "15:00:00" },
                    { new Guid("24739870-6712-465c-bf88-3926c546e780"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-826216", "10:00:00" },
                    { new Guid("24bead0e-dd0c-40e6-8d6c-830c12125748"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-49693", "09:00:00" },
                    { new Guid("258108b6-22ba-42b6-a9b4-e5c29ac99d2e"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-734593", "15:00:00" },
                    { new Guid("2590391a-97e5-454b-9732-5a52aec76b03"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-442502", "12:00:00" },
                    { new Guid("2594ab6d-6a1d-4d4c-92a7-617e78386970"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-931738", "17:00:00" },
                    { new Guid("26174ed3-6ea7-464d-aa5d-e22635129b60"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-856619", "10:00:00" },
                    { new Guid("2683e1bd-3777-418f-b045-58fbb1981914"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 27, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-216629", "13:00:00" },
                    { new Guid("26872035-9b0b-4988-b916-8ff0a123bad5"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-351462", "17:00:00" },
                    { new Guid("27ec395c-96dc-40e6-b043-74f51f7837a6"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-237295", "13:00:00" },
                    { new Guid("283567fd-6b2f-42e2-aacf-566f6a691d29"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-464658", "08:00:00" },
                    { new Guid("289c37b8-9673-4239-8aed-dc0d91411f4d"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-331280", "17:00:00" },
                    { new Guid("28eebef2-4cb1-4e0a-8829-bc6138bc5d41"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-759411", "16:00:00" },
                    { new Guid("29ba74ca-49e8-4025-8482-d291722d52a4"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-573076", "13:00:00" },
                    { new Guid("29be5e4f-be95-4c5e-a45c-d04fad095c2e"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-233299", "15:00:00" },
                    { new Guid("29dce466-84c6-44bb-8515-0ef518375849"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-300931", "14:00:00" },
                    { new Guid("2a12038b-892a-4ca6-955e-8a04bbcea8c4"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-112241", "13:00:00" },
                    { new Guid("2a9134cf-de3a-445a-8c06-fc64224849c1"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-892837", "16:00:00" },
                    { new Guid("2b37c7d0-2bcb-41d8-8496-9814251099f3"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-754950", "14:00:00" },
                    { new Guid("2d0af977-aaee-42a0-9b86-0217349cc1a0"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-188618", "15:00:00" },
                    { new Guid("2e0b6d4f-7216-4346-b993-3a0631c31d88"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-572015", "12:00:00" },
                    { new Guid("2e1c7c1a-033f-41f3-82d7-771c6fb40fab"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-185336", "14:00:00" },
                    { new Guid("2e581802-1b42-472d-bd1f-e5fc38fbd8f9"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 27, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-717253", "12:00:00" },
                    { new Guid("2ef59a17-db1c-4267-9df8-0634f7d1f3fa"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-281375", "12:00:00" },
                    { new Guid("2f2d3ffd-c8a8-4059-b5cf-14151cd0c58c"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-899076", "14:00:00" },
                    { new Guid("2fee2cf1-1f9f-49e2-96ae-2968b4c2f7db"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-633332", "15:00:00" },
                    { new Guid("3041e751-ad99-4edf-a50b-1c1f7a75f75b"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-759575", "12:00:00" },
                    { new Guid("316a6687-d301-4104-a313-cc6d3fc63d4c"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 13, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-399322", "12:00:00" },
                    { new Guid("31c441df-2bdd-427c-a641-c9485058f311"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-192436", "09:00:00" },
                    { new Guid("321ff8ae-f663-4117-8ad9-b9f603ad08c8"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-1092", "12:00:00" },
                    { new Guid("34926054-fdb5-4a2d-baef-724201432d17"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-112986", "12:00:00" },
                    { new Guid("34ade93b-72cb-46fc-b350-1fb7fb3f7b93"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-376632", "16:00:00" },
                    { new Guid("3542117a-b197-4c55-b3bb-069ac8f5929f"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-21078", "14:00:00" },
                    { new Guid("35775eec-ded1-4c8c-a0e8-c18767a71906"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-870726", "10:00:00" },
                    { new Guid("368c45ca-7532-4c6f-909a-37166f869c50"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-362823", "12:00:00" },
                    { new Guid("36bad877-0514-4ba0-a39c-6abc81f6bf2f"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-377023", "13:00:00" },
                    { new Guid("376c4759-3bc5-48fb-8b0e-2d93e30c3247"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-117964", "17:00:00" },
                    { new Guid("38f03aa0-8f50-4678-8857-8628b1a2c177"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-230665", "16:00:00" },
                    { new Guid("3af16e01-b93f-4a37-ab79-9b90289f4868"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-876931", "09:00:00" },
                    { new Guid("3b62e50c-ca45-4789-aaa3-99e173a76217"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 13, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-651760", "09:00:00" },
                    { new Guid("3ca17bed-c61f-4fa9-9754-447d6d104b0e"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-522504", "10:00:00" },
                    { new Guid("3e2fc51b-3fb4-4712-a149-af1c182a9ff8"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-53226", "09:00:00" },
                    { new Guid("40a7426e-f7ad-4f98-acd4-0da99924cedb"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-684982", "10:00:00" },
                    { new Guid("413d27d3-9952-40d9-9ab1-22d7abbce589"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-175280", "11:00:00" },
                    { new Guid("41a52192-60dc-4364-86f5-c5286a4ff4ee"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-839902", "12:00:00" },
                    { new Guid("424762c1-2077-43d9-a6f5-ecee63cfee07"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-398733", "10:00:00" },
                    { new Guid("427a4f97-bdc6-4a7d-a8e7-45c06e107952"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-407977", "11:00:00" },
                    { new Guid("44a303e1-21b9-465e-bdb0-fa7e934bbaab"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-423882", "17:00:00" },
                    { new Guid("44f59567-d587-4b7b-9681-88ea188545c2"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-719854", "11:00:00" },
                    { new Guid("44f9e94a-8ef1-429c-8477-5956832c4e15"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-114556", "13:00:00" },
                    { new Guid("4564f744-c107-494b-9585-4e41af673c9a"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-716615", "10:00:00" },
                    { new Guid("4639ae6d-774c-4eb7-946e-41e0e61bc5f9"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-912147", "08:00:00" },
                    { new Guid("46e2c2ee-8b06-4db3-a358-5d9486f15766"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-419187", "12:00:00" },
                    { new Guid("471b2a8d-5abb-4258-b321-297e093af845"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-783180", "13:00:00" },
                    { new Guid("476d6bdf-1e71-4a7c-9935-26f3d48378d7"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-93347", "13:00:00" },
                    { new Guid("47ee3890-c53d-4908-92e3-ff39dce40130"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-77603", "10:00:00" },
                    { new Guid("481bbe5f-8a14-4e36-9116-a45464278763"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-2558", "10:00:00" },
                    { new Guid("4947bd1a-20f0-4c27-a70b-6670fbfcb0dd"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-440138", "16:00:00" },
                    { new Guid("4a0d02d9-ad3b-4126-aff1-be5b35c6af00"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-17400", "16:00:00" },
                    { new Guid("4bbc8b6a-a7bf-4799-85b0-4313d04c0014"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-287424", "10:00:00" },
                    { new Guid("4c65493c-a6c2-4c7e-b9e4-b947ec2ac68a"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-75797", "13:00:00" },
                    { new Guid("4cb409ae-f21f-4837-aa63-900975742f12"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-86382", "16:00:00" },
                    { new Guid("4d4a0cc0-d60f-433b-a55e-b7687b347c40"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-768977", "14:00:00" },
                    { new Guid("4defb677-5c55-43c2-83b3-e374e216fa8b"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-230077", "15:00:00" },
                    { new Guid("4e3a13ca-86f3-4b90-ae19-0e82ec7b008d"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-583419", "14:00:00" },
                    { new Guid("4ec5f547-6675-41e1-ba3d-a9bb5ee0b3cb"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-789846", "10:00:00" },
                    { new Guid("4ec80506-23d4-42b0-a0ec-af612265301c"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-9104", "10:00:00" },
                    { new Guid("4f39e1a3-1b2f-4fca-b2b1-a8b2be2b39e2"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 14, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-624512", "13:00:00" },
                    { new Guid("4f81b3b2-a264-40fe-88e6-659e75cbfa92"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-27115", "09:00:00" },
                    { new Guid("4fb3921b-a692-4b77-8421-f88ec676c3dd"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-355019", "09:00:00" },
                    { new Guid("50496808-9b93-4661-83eb-d15dfdac7056"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 27, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-564005", "10:00:00" },
                    { new Guid("51d80f6c-2b16-417f-89cf-d912e9cbbdb6"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-280678", "10:00:00" },
                    { new Guid("51e6080c-728d-4e5a-b5df-05417fd43847"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-913547", "12:00:00" },
                    { new Guid("52486575-4105-438e-b809-c99b4189aaa6"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-53065", "15:00:00" },
                    { new Guid("547ea4b2-dbd0-4ddb-97e9-cf24763bb6da"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-968061", "14:00:00" },
                    { new Guid("55b7f7f7-1970-43af-ac8f-a53beace83a9"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-266559", "09:00:00" },
                    { new Guid("568f7343-4f09-43bf-9aa8-3a3d5dc51811"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-501837", "12:00:00" },
                    { new Guid("57222e73-91f2-413c-8dac-a3dc21f4d097"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-483693", "13:00:00" },
                    { new Guid("57796a87-9011-49a7-b691-7c39dc6861e0"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-520772", "08:00:00" },
                    { new Guid("57f03ef2-0215-4529-83ce-a14f312f443b"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-264853", "08:00:00" },
                    { new Guid("58474d07-052e-4e7e-b9c6-795141c54c07"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-547665", "11:00:00" },
                    { new Guid("5a49b010-7de4-47f4-a011-55a28ade205d"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 28, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-208546", "13:00:00" },
                    { new Guid("5a9e9d0c-a293-4dd2-8d4f-c83494bb7b26"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-649862", "15:00:00" },
                    { new Guid("5afffb5f-0fa9-4d1d-9aa4-aac82a2fa849"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-672250", "14:00:00" },
                    { new Guid("5b4d54d4-434c-4df8-9011-c0b2f92978ec"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 13, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-823793", "10:00:00" },
                    { new Guid("5ba2b145-987b-4649-b2a8-6a38a0896b8b"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-394196", "15:00:00" },
                    { new Guid("5c5c5cd6-4274-460a-8b20-8e3c36b5ab96"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-605025", "11:00:00" },
                    { new Guid("5c64ee4a-fc48-4d80-a3a4-a434a6574bac"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-710201", "15:00:00" },
                    { new Guid("5c849c47-22a2-4f2e-93b7-46c8f0940be2"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-480454", "13:00:00" },
                    { new Guid("5d03bc1f-709a-403b-8d8c-4915f3377a94"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-969989", "11:00:00" },
                    { new Guid("5d0e6c50-02db-4d7b-9908-e72cc6a2539d"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-136684", "09:00:00" },
                    { new Guid("5e60c1ab-c73b-4f61-af6b-0b74ff08f69e"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 28, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-344960", "13:00:00" },
                    { new Guid("5ec93ebc-2bc0-4a5c-8fc5-5bb8c9a3233f"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-155014", "15:00:00" },
                    { new Guid("5f373d3c-9094-4d6f-8590-a391d722e25c"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-1542", "14:00:00" },
                    { new Guid("60017284-c9d1-4106-ae85-35fd72249c0a"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 13, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-233015", "10:00:00" },
                    { new Guid("606a3f7f-9c6f-4761-8704-a5bf8add09e6"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-904989", "16:00:00" },
                    { new Guid("60b769c5-1fc7-468a-829f-0c0b8133beee"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 13, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-982719", "14:00:00" },
                    { new Guid("616c3748-7363-49c5-ba53-7d6e68b073f0"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-526471", "12:00:00" },
                    { new Guid("61aec1bb-dee8-4953-8e50-cdb437ea9c34"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-80342", "09:00:00" },
                    { new Guid("62be3e89-41a4-4090-9212-ca346d1c9468"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-298386", "14:00:00" },
                    { new Guid("62e0f79f-314c-42d3-ae7f-f983b73f304e"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-348598", "11:00:00" },
                    { new Guid("632c556b-59d4-446a-adbc-4b054f49f3b6"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 14, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-229347", "15:00:00" },
                    { new Guid("633b4e38-adfe-41eb-98d1-8e356251df1e"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-474492", "09:00:00" },
                    { new Guid("635d35c6-d5c7-4429-99bf-d7d7746e8e8e"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-891116", "09:00:00" },
                    { new Guid("656d8e4a-65a0-40a9-85fd-2e2a790d8ca0"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-262890", "08:00:00" },
                    { new Guid("65d01b5f-1831-42b9-a029-389beec88082"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-942304", "09:00:00" },
                    { new Guid("660d6a9a-470f-488a-8201-b35c46846deb"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-177455", "14:00:00" },
                    { new Guid("670ca4ee-e919-4c4c-84c6-a40627aa168c"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-967276", "10:00:00" },
                    { new Guid("683b23a9-c0b7-4813-a786-0273264cd0e8"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-233249", "12:00:00" },
                    { new Guid("686cd665-4524-469a-bc1c-4bd2d2511227"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-231313", "15:00:00" },
                    { new Guid("6901707b-ca1e-4f68-8a47-f285b1d2feac"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-289502", "15:00:00" },
                    { new Guid("6a396a21-f3dd-42b6-b257-e0526be6e702"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-189093", "15:00:00" },
                    { new Guid("6aea5333-a431-4002-9dcf-8aac5244d7ad"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-314253", "14:00:00" },
                    { new Guid("6b458b1e-ad06-4bfc-aff4-b1b2dfe3ee29"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-541976", "15:00:00" },
                    { new Guid("6c948f21-f9d7-40b9-9d10-a04e024b6ea0"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-299095", "14:00:00" },
                    { new Guid("6cb9c018-f36e-4db6-935d-2634e501910c"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-517440", "11:00:00" },
                    { new Guid("6db68e3f-8a5d-4b58-88bd-006adf07e4d7"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-794763", "12:00:00" },
                    { new Guid("6f563eb9-2ff2-41a6-96dd-55fee040a7d6"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-830269", "12:00:00" },
                    { new Guid("6f784dd5-4b16-48ad-947a-08eb981a0d81"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-503439", "12:00:00" },
                    { new Guid("700e04ad-81bc-4e41-99e1-dcd33d45765a"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-720395", "14:00:00" },
                    { new Guid("71bb0210-7b03-4ccb-90e7-5913ce9c9f9d"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-917491", "13:00:00" },
                    { new Guid("72a3bc0d-82f6-445f-a89e-dc3d31f65f79"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-947810", "09:00:00" },
                    { new Guid("72b736a8-8408-459f-975e-5965a07374f4"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-580905", "13:00:00" },
                    { new Guid("730d9ec6-b5d6-428e-94dd-aeaec9ef8491"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-963085", "10:00:00" },
                    { new Guid("73159a53-bf9e-402c-82ca-29196d3aea50"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-258914", "12:00:00" },
                    { new Guid("73683764-b00f-4c9a-b1ea-07d6cb5b4097"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-805073", "09:00:00" },
                    { new Guid("73d12bdc-238e-45ec-aa3a-fc24982492a6"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-623200", "13:00:00" },
                    { new Guid("74070cde-7f43-4c2c-805a-bcc445f5b38d"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-241112", "14:00:00" },
                    { new Guid("74e77f21-05b0-4e70-820a-e90a8ec55791"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-102051", "08:00:00" },
                    { new Guid("760c74d7-62bd-477b-8a84-1720a96d82d9"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-647607", "10:00:00" },
                    { new Guid("765a9b2c-2da5-4d61-b25b-cacc3fa8a63a"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-918716", "08:00:00" },
                    { new Guid("7717b54f-cd1f-4dd5-9004-306ef3891e41"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-850803", "10:00:00" },
                    { new Guid("773ea1d7-f8bf-4c95-b8d6-1620c878eb78"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-643736", "14:00:00" },
                    { new Guid("77ec435b-d398-4ab3-a9bd-30993f3dd81c"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-962283", "14:00:00" },
                    { new Guid("786682b1-9f19-45a9-97ee-b1dbaaaecaf1"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-696405", "10:00:00" },
                    { new Guid("78c4cbe5-209a-4536-ba54-c376db3c5d06"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-957086", "14:00:00" },
                    { new Guid("78dd6168-7df7-4fd7-9786-0c422b745b92"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-274589", "11:00:00" },
                    { new Guid("78ff43c0-2a33-4ae8-a258-879fa32997fa"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-82930", "11:00:00" },
                    { new Guid("79fa0585-320a-4ded-9c6c-9ba029bd03ea"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-359802", "14:00:00" },
                    { new Guid("7cad554e-0d80-46a6-be9c-afdd8882a56c"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-850568", "11:00:00" },
                    { new Guid("7db83cbe-db2c-47fa-823d-f89dd486c83f"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-335612", "12:00:00" },
                    { new Guid("7e1e7d10-10d9-4bc2-ba10-2e5760e1a55d"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-706195", "09:00:00" },
                    { new Guid("7e293435-a128-4557-9d82-89593941b222"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 27, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-286009", "15:00:00" },
                    { new Guid("7e5b7d60-8f5b-4345-adcc-f1cf1c2610ba"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-677514", "16:00:00" },
                    { new Guid("7f1a3b7f-450e-4269-a5bd-536da316ab05"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-227511", "17:00:00" },
                    { new Guid("7f396e67-7c29-4cfd-aab5-83ac8c9c9c2f"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-809688", "14:00:00" },
                    { new Guid("7fb5f442-8d48-462c-bc91-19a3ae8f099c"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-668120", "14:00:00" },
                    { new Guid("805d488b-a36c-499e-8148-182beb5d73b1"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-584141", "14:00:00" },
                    { new Guid("8090bfc6-92ba-4551-b66f-bc82125073f7"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-254952", "09:00:00" },
                    { new Guid("80fbdf5f-234d-4fe3-a220-115b5ea5ddcd"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-97070", "10:00:00" },
                    { new Guid("81822ee1-a304-411a-9694-1485333a480e"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-145280", "09:00:00" },
                    { new Guid("81846bce-da8e-4c71-bfb9-c6ab8b6a09c0"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-123148", "10:00:00" },
                    { new Guid("82f00b23-55c3-4fd2-999a-cba36b17bcbc"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-127342", "11:00:00" },
                    { new Guid("83e26c2a-b869-4abe-b0c0-2fef02cd61c6"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-635471", "09:00:00" },
                    { new Guid("865b0916-6a49-4331-862e-4c2d5664b76b"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 27, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-638641", "09:00:00" },
                    { new Guid("871c7551-8f69-416b-b91f-449d137de89d"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-687086", "13:00:00" },
                    { new Guid("884e1d46-e865-4733-bd4e-8703aadec435"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-351372", "09:00:00" },
                    { new Guid("88ace37b-e6b8-4fea-a02b-9fef55fe4c55"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-970166", "16:00:00" },
                    { new Guid("893c0b41-37e5-4937-bb36-78d9024b4589"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-492579", "16:00:00" },
                    { new Guid("8a054ddf-b329-486e-8f73-90337ac2d329"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-446973", "12:00:00" },
                    { new Guid("8c2cece1-aded-4b0d-89c7-baa87a45af68"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-898559", "13:00:00" },
                    { new Guid("8cd403f2-e844-4c20-91e6-e13480d1167c"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-12825", "15:00:00" },
                    { new Guid("8e435f6e-ed5a-41e3-8840-e8a64a8640c9"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-58506", "13:00:00" },
                    { new Guid("8e4d3fb8-61ca-4b10-93b8-6ff818bb496a"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-702777", "09:00:00" },
                    { new Guid("8f3d2c21-d8c8-4f79-8a8d-85d1cb223e70"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-125096", "15:00:00" },
                    { new Guid("8fd2b12d-5776-4895-9d3c-40be97c3d807"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-550225", "10:00:00" },
                    { new Guid("90ee9245-2c58-4e6a-a746-14ada87ed91b"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-648914", "10:00:00" },
                    { new Guid("90fee299-dc67-4a0c-945f-9fac9ab860d4"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-150544", "12:00:00" },
                    { new Guid("9140e21a-5187-4379-9dbe-46497d9afe3c"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-679299", "17:00:00" },
                    { new Guid("93069726-28bf-48c0-87fa-8324fc5d226d"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-737182", "15:00:00" },
                    { new Guid("93639d82-96c3-4008-ab51-74b30fe35225"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-721765", "09:00:00" },
                    { new Guid("94db7c18-e1ed-4317-bf73-ba835df4a61d"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-374935", "10:00:00" },
                    { new Guid("95e801a1-77e5-4d73-8c29-f075302914bb"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-452280", "11:00:00" },
                    { new Guid("9614ce83-bcdc-4c03-9962-f1355d534ec6"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-893211", "15:00:00" },
                    { new Guid("96538f02-9ea4-4f99-9263-3ff9c74e2c17"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-983795", "13:00:00" },
                    { new Guid("967c47e7-2409-496b-ba2b-43e5c3dfe7b3"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-718953", "09:00:00" },
                    { new Guid("96d38851-8d5e-45f1-a0fd-2c776d112e74"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-149374", "10:00:00" },
                    { new Guid("97006098-9f4b-459c-89ca-a220da7e3474"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-145664", "16:00:00" },
                    { new Guid("974875a6-b866-4e4a-a9f9-0e35633de0e0"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 28, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-795402", "14:00:00" },
                    { new Guid("974c8e0e-c469-4a45-9674-c4c4dacefa6d"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 27, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-823019", "09:00:00" },
                    { new Guid("984229df-e3b2-40ac-8638-7133115a9846"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-6918", "14:00:00" },
                    { new Guid("9894d8d1-018c-44c8-88b8-309ffa217a7b"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-982319", "13:00:00" },
                    { new Guid("9a4d25fe-2f9a-4c8c-ba2a-ea54bb725322"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-727323", "14:00:00" },
                    { new Guid("9afc79a3-444a-4653-806a-58d0d162d77d"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-936312", "12:00:00" },
                    { new Guid("9b1ac5c3-6cd7-4bf2-9743-36646592b9f7"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-854630", "11:00:00" },
                    { new Guid("9baa0571-8bd9-42c8-8cb4-f660f84539e2"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-97116", "12:00:00" },
                    { new Guid("9c279c68-d3b0-4c69-8d25-139fab7ed87e"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-805246", "13:00:00" },
                    { new Guid("9cd507c7-a12c-4c03-b637-e85468e81ecc"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-87733", "16:00:00" },
                    { new Guid("9d9e6ffa-ae23-4d74-8e02-9e1b71dcc330"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-885018", "13:00:00" },
                    { new Guid("9e5dff47-748d-435f-94ff-0adf0ea2884c"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 14, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-66320", "14:00:00" },
                    { new Guid("9ee07345-8222-4646-83ad-21634f718f7f"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-96981", "11:00:00" },
                    { new Guid("a0a88a5e-bbec-4b39-9d79-a2fa74401c42"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-591259", "13:00:00" },
                    { new Guid("a160228a-7649-4a35-b70a-825764be1431"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-542960", "17:00:00" },
                    { new Guid("a25fe8d9-104c-4217-9284-716b9aff1d27"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-893155", "16:00:00" },
                    { new Guid("a292b883-d9dd-4b19-b4ec-df13e68958ee"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-331788", "14:00:00" },
                    { new Guid("a2b0cb2e-f5a4-4b6b-8ff6-a23b931ed563"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-72938", "12:00:00" },
                    { new Guid("a3294d34-3585-4b3c-8fe7-cfbc7a4c573b"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-565636", "14:00:00" },
                    { new Guid("a32bf527-64af-4d0e-b2f8-b540d015b08d"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-331690", "11:00:00" },
                    { new Guid("a384e267-61fd-4b60-8bda-1d02c24348e1"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-156115", "10:00:00" },
                    { new Guid("a4231ae5-829a-4210-8c1f-b454ec5c6dd2"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-4255", "13:00:00" },
                    { new Guid("a57f32d2-400b-4d1a-898d-82dfc585dffa"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-936619", "10:00:00" },
                    { new Guid("a5cac9b9-333a-4b29-bcff-b492ad76fbb7"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-890670", "16:00:00" },
                    { new Guid("a603958e-03e4-48cf-b3c3-2b0ed2b0cbca"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 27, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-585291", "11:00:00" },
                    { new Guid("a63aff12-b635-46f1-b23c-836b1603f8b8"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-202691", "09:00:00" },
                    { new Guid("a667edf5-0a10-46f8-9c06-191a0a7ce30b"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-998797", "09:00:00" },
                    { new Guid("a67759ba-103b-4952-883a-0a106819b550"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-834719", "12:00:00" },
                    { new Guid("a7073c71-2f5d-493b-bd81-ac6389ea13e0"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-332504", "15:00:00" },
                    { new Guid("a717535b-da52-4406-9304-1f560f928e9a"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-925845", "16:00:00" },
                    { new Guid("a94c4f0d-0246-4aef-8786-c675cf71d220"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-473277", "10:00:00" },
                    { new Guid("a9882254-dae6-4c9f-bdc0-7cb68ae3d085"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-331643", "15:00:00" },
                    { new Guid("a9d56366-03c7-414b-a9df-ffa69aa24811"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-530066", "09:00:00" },
                    { new Guid("aa544b88-8608-41e2-be8b-5b2e30c5a0c1"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-188686", "16:00:00" },
                    { new Guid("aab97681-632b-4c2a-9da3-631da07b33c6"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-242327", "15:00:00" },
                    { new Guid("abf94f91-edd7-4b72-865a-9ed6c9071baf"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-70455", "15:00:00" },
                    { new Guid("aca7fa8d-767c-4412-96bd-be35aa8ae05a"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-594099", "11:00:00" },
                    { new Guid("ae585b00-ca39-4c57-8912-3d538d874c24"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-903491", "09:00:00" },
                    { new Guid("aefd7dcb-fea6-4f43-b09d-749a0dbcb104"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-809040", "14:00:00" },
                    { new Guid("af8859be-ad5f-428d-96a5-9bb3b5fcc935"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-908226", "15:00:00" },
                    { new Guid("afc5aadb-a043-48f7-a595-8e24eb304d93"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-16470", "12:00:00" },
                    { new Guid("b01b8172-ff95-41b1-9ce0-6678b8839e61"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-271613", "11:00:00" },
                    { new Guid("b02d7c4a-64ea-4e87-b789-a8d4240c76dc"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-129741", "13:00:00" },
                    { new Guid("b13999f8-94eb-4258-bc2f-4d9e99e1bdb8"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-867594", "09:00:00" },
                    { new Guid("b1d3f625-52c3-455a-904d-dc8a55afc320"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-906659", "09:00:00" },
                    { new Guid("b228461e-a668-4365-b482-ef3de38801e0"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-939809", "14:00:00" },
                    { new Guid("b2bded2f-b45e-493c-840b-89c3f9230cf9"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-673524", "13:00:00" },
                    { new Guid("b36bddb9-957a-453c-80f2-536274d5746e"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-294793", "11:00:00" },
                    { new Guid("b44b07e2-83dd-4c98-8905-9368ba932479"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-317748", "11:00:00" },
                    { new Guid("b48c6830-9c44-47aa-8905-7f967dbf28d1"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-642752", "12:00:00" },
                    { new Guid("b522bf8b-5cb0-4767-99a5-77b6e1c75ab4"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-586621", "13:00:00" },
                    { new Guid("b8295c3b-3aa4-4d04-a624-7b27ef6fae7c"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-467050", "13:00:00" },
                    { new Guid("b90b188c-bc5e-47ab-8f6d-3dbd1fa8a5e9"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-145662", "12:00:00" },
                    { new Guid("b95cfc3f-bb3a-4d75-a7d0-55eaeed6b30e"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-18124", "09:00:00" },
                    { new Guid("ba274730-5d3c-4963-b869-48801656f55e"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-302818", "13:00:00" },
                    { new Guid("ba61b783-a836-4957-8802-29fcab2dd35c"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 12, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-890710", "15:00:00" },
                    { new Guid("bb05cfde-c54e-404e-a6ec-ca575bcbe80f"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-388179", "13:00:00" },
                    { new Guid("bb2b0fa4-ee6e-4650-a36d-4bc4bea7c8c5"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-844713", "13:00:00" },
                    { new Guid("bbbb6643-1f6c-4eb4-87bb-a2c9a591a45d"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-1037", "10:00:00" },
                    { new Guid("bc955bd4-cbba-4c35-b063-4ca5c5f46c42"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-266395", "13:00:00" },
                    { new Guid("bd5bc840-4e19-4614-b0f6-158d7da3ea20"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-429076", "14:00:00" },
                    { new Guid("bd68a502-164d-4380-8d90-ba21457b2fba"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-713479", "11:00:00" },
                    { new Guid("bd771dfc-21ce-412e-b81e-071d7818c47f"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-59534", "14:00:00" },
                    { new Guid("bdb6254e-d88b-49ea-bf4b-1d05d1dd9ca6"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-128811", "16:00:00" },
                    { new Guid("be522b80-6bb4-4bfb-a7dc-fd2fcda6995c"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-370530", "14:00:00" },
                    { new Guid("bf0a3b6b-d48a-4a47-bce5-9335d67f7e63"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-765237", "12:00:00" },
                    { new Guid("bf4687f0-e928-422b-b2d1-d96621b58ca0"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 28, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-528395", "10:00:00" },
                    { new Guid("bffa2168-6284-46c1-b364-28cc19a3f464"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-127174", "11:00:00" },
                    { new Guid("c040f632-b68a-4f6d-985d-eade20bdd34a"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-336512", "12:00:00" },
                    { new Guid("c0c33498-5559-4652-8e83-74c6a7406bb3"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-755992", "15:00:00" },
                    { new Guid("c1473d9f-c07f-4466-9f66-27255feddcc8"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-147552", "16:00:00" },
                    { new Guid("c19c0641-a582-4c6b-bfaf-108c8e5fce95"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-230862", "09:00:00" },
                    { new Guid("c1bd813e-7986-41fd-a861-a50b04abe596"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-552084", "12:00:00" },
                    { new Guid("c1fbeafc-663a-4a5a-aa2a-2e24bdcaa753"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-459567", "14:00:00" },
                    { new Guid("c31091d4-6154-433a-9d04-baf92987268a"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-146764", "14:00:00" },
                    { new Guid("c4b7d8c1-8066-44f3-940d-f26c9099f793"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-18659", "13:00:00" },
                    { new Guid("c4bc4652-9182-4fce-a3cb-8dadc99848e3"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-828678", "12:00:00" },
                    { new Guid("c7084e5e-6358-4663-bb31-c998314bdbf4"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-814836", "10:00:00" },
                    { new Guid("c7b06ba7-044b-4961-8130-5f09a3853e5d"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-943858", "14:00:00" },
                    { new Guid("c7cd0270-8395-4f57-be4d-156caf841a05"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-310156", "13:00:00" },
                    { new Guid("c88c12f4-0428-4b7a-8a20-8e303f6bedd7"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-510377", "16:00:00" },
                    { new Guid("cbddb3b5-5fe6-4288-a0cf-addeb300ef52"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-402432", "10:00:00" },
                    { new Guid("cc6603cd-5780-482d-b444-0f4d92ef0e2e"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-515349", "11:00:00" },
                    { new Guid("cf6dc8e9-f8c5-40e5-b29a-ee02c9dbfa45"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-271465", "15:00:00" },
                    { new Guid("d09feec7-a5e5-4e87-8081-8438c6944aef"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 9, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-785636", "11:00:00" },
                    { new Guid("d0d78557-b4c0-4675-bc36-ee6d39fe466f"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-220206", "12:00:00" },
                    { new Guid("d1507355-e277-46ae-bbb9-718e634d2305"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 20, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-60346", "12:00:00" },
                    { new Guid("d16c8244-d01a-4083-b54b-2479329a3982"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-278361", "14:00:00" },
                    { new Guid("d1854a11-4a09-4d8a-883b-cfaa3ba5ae81"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-487189", "14:00:00" },
                    { new Guid("d3f892ac-01ed-4e70-b044-160c96e969f5"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-924967", "14:00:00" },
                    { new Guid("d46a2eef-b40a-4bbd-831b-86fe7b3892f5"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-112419", "11:00:00" },
                    { new Guid("d559eaae-c856-4d7e-9449-29c76890aa45"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 14, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-19780", "14:00:00" },
                    { new Guid("d5ca0ef0-e42b-48bf-b44b-b3e8684dc80a"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-684359", "12:00:00" },
                    { new Guid("d7796a30-fb8b-4574-8fd2-58bc08f63e8c"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-999556", "09:00:00" },
                    { new Guid("d830d78e-819d-421d-a172-543f21dd2c76"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-340269", "15:00:00" },
                    { new Guid("d8bc6421-b3bc-45c3-b02a-a7e50c0fbb84"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-558815", "11:00:00" },
                    { new Guid("d90f7a0a-2448-4154-b368-65409d632de4"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-900012", "11:00:00" },
                    { new Guid("da0cd0d8-7b7a-4b47-b075-157997ae68ff"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-443717", "09:00:00" },
                    { new Guid("da25231d-bbd4-45bf-9525-9dc546af1748"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-43098", "15:00:00" },
                    { new Guid("da312297-79e2-4fd8-b3de-2b0365d05a68"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-571037", "15:00:00" },
                    { new Guid("daaca9c2-c54b-4ba0-a047-169d2ce4f8cc"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 13, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-877691", "10:00:00" },
                    { new Guid("db6e177b-4f66-4d42-b49f-afdd14b345d4"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-383939", "10:00:00" },
                    { new Guid("dc4b3ccd-c78b-4ece-9749-b42784d49e73"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-583531", "14:00:00" },
                    { new Guid("dd7b4ff9-adab-4975-a68c-3ebca6c4de47"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-912146", "09:00:00" },
                    { new Guid("dda0b761-dc19-4d23-9e14-a6ac71220f39"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-662551", "09:00:00" },
                    { new Guid("ddd00cdc-1993-437b-83f7-0af44ddd6edf"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-708991", "15:00:00" },
                    { new Guid("df481487-20e3-43a4-be87-ecbf38f7941b"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 16, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-241058", "09:00:00" },
                    { new Guid("e01635c4-422a-46bb-ae49-17981f0a51d6"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-238817", "16:00:00" },
                    { new Guid("e139397c-11b4-441f-b891-a888e7b5a068"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 27, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-645783", "14:00:00" },
                    { new Guid("e199c07b-eac9-4f07-90c1-db23c11fc958"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-182557", "11:00:00" },
                    { new Guid("e3968c95-0e40-4ccd-90f3-e2f8f64704bc"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-921229", "14:00:00" },
                    { new Guid("e3f2ed2d-b198-4eed-8fb0-b91d636adccd"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-181785", "12:00:00" },
                    { new Guid("e510417d-dfa1-417a-83e6-f2ad45f2fe99"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 27, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-328166", "12:00:00" },
                    { new Guid("e5b6d2a5-1449-4011-b983-808a24938779"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-381233", "14:00:00" },
                    { new Guid("e758bdc4-dc58-4cca-b95d-4eaf4f619feb"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 29, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-797846", "09:00:00" },
                    { new Guid("e7e07eab-74af-4297-8b74-7167a7b2c732"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-734744", "13:00:00" },
                    { new Guid("e94b5c16-0ab3-474a-bacd-ed08aa8ca795"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-559285", "15:00:00" },
                    { new Guid("e96f6ece-7a6f-4e46-8520-efd4a2781ceb"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-524026", "10:00:00" },
                    { new Guid("eba91117-f8c8-4add-a041-3ebd844738d8"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-100421", "14:00:00" },
                    { new Guid("ec6e4847-95ae-4e18-8dff-a1c3d7c292a1"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-162317", "12:00:00" },
                    { new Guid("ed094942-60b4-43c9-8ae4-c874a3e595f3"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-165471", "11:00:00" },
                    { new Guid("ed2231c2-b84f-40bb-a47b-2d8f3121f6f4"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-263656", "11:00:00" },
                    { new Guid("ed40bab9-4e5e-48e6-91b3-44af6c6e2716"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-683162", "11:00:00" },
                    { new Guid("ee6030de-3d96-4ee1-b22c-a8706d291eeb"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-462423", "17:00:00" },
                    { new Guid("ee6bf6a8-c5e1-41a0-83b1-f4c275857b3f"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 19, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-190143", "11:00:00" },
                    { new Guid("ee95da7d-7901-4e30-ab19-68445894ed9e"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-929423", "09:00:00" },
                    { new Guid("eebcf1c5-3f7d-438d-b378-39b468ded7dc"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 13, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-214493", "09:00:00" },
                    { new Guid("ef248f66-b634-4a5d-b451-e59be15ed0ee"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-311801", "16:00:00" },
                    { new Guid("f01eea17-5c1b-4650-8472-71ab442a49ef"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-86644", "15:00:00" },
                    { new Guid("f0cd0c94-670b-42b5-aab1-30927bf3efc3"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-584178", "17:00:00" },
                    { new Guid("f17d9ade-2eae-4d94-850d-6880723b86a2"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-675001", "10:00:00" },
                    { new Guid("f1e6ee23-7f98-4e0c-bfe2-d2f9be858ae7"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-106950", "16:00:00" },
                    { new Guid("f31df194-a7ff-4570-a089-f0482762037c"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 23, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-525908", "11:00:00" },
                    { new Guid("f3a918ed-3b0d-4a1e-b127-4ab45ee96c0c"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 21, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-340623", "13:00:00" },
                    { new Guid("f406198e-4c1e-493b-bb9e-3d900f81f27f"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-610404", "13:00:00" },
                    { new Guid("f47444ce-6bef-450b-a3d7-481ea419cb2b"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 17, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-802074", "16:00:00" },
                    { new Guid("f525045f-526a-4cc9-9dd8-907420eb9fc2"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-560904", "10:00:00" },
                    { new Guid("f6d4f435-ab2f-49d2-8e67-5ab3344b22a6"), true, new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-553440", "13:00:00" },
                    { new Guid("f79ea623-c0e9-4afa-9c1b-7a4948a13593"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 24, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-927646", "13:00:00" },
                    { new Guid("f7f045f8-8545-4481-8a2f-023a3257da60"), true, new Guid("0d819742-cd02-467c-9116-210baf093806"), new DateTime(2025, 12, 25, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-753275", "10:00:00" },
                    { new Guid("f835c454-4b9a-4d79-8bbd-73d495568d2c"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 14, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-536848", "12:00:00" },
                    { new Guid("fa6678e3-0438-4b82-8cf6-2594525e5d2e"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-827269", "17:00:00" },
                    { new Guid("fa7a51d3-7012-469b-9c18-f08b51c3968d"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 22, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-493748", "16:00:00" },
                    { new Guid("faf25b88-b97f-41e8-9818-882ea1608aaa"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-577102", "13:00:00" },
                    { new Guid("fbbb3e01-bcf3-4162-9e3e-a92cf7de942d"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 26, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-660453", "16:00:00" },
                    { new Guid("fbcd3a81-fd29-4783-9f63-7476e87b3ad2"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-710495", "09:00:00" },
                    { new Guid("fc6a9274-2cb3-4a2d-ac58-05f7a809a8a0"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-696893", "16:00:00" },
                    { new Guid("fda1223d-791d-4118-8e5a-8674c05e0d47"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 15, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-524178", "13:00:00" },
                    { new Guid("fde54be8-4dcb-4411-b118-08f63445ae81"), true, new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new DateTime(2025, 12, 18, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-463386", "12:00:00" },
                    { new Guid("fe764af6-e531-4f95-9cff-6a4a3580127a"), true, new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new DateTime(2025, 12, 11, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-494994", "11:00:00" },
                    { new Guid("fe8bc1c1-685d-4880-a4de-54a5ecdde12a"), true, new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new DateTime(2025, 12, 13, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-796884", "11:00:00" },
                    { new Guid("ff9601d7-d166-474d-88d1-2202620dd219"), true, new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new DateTime(2025, 12, 10, 20, 25, 24, 524, DateTimeKind.Local).AddTicks(5411), "PB-459877", "16:00:00" }
                });

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("0d819742-cd02-467c-9116-210baf093806"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("2786bf11-426a-4450-83e3-f0356c929273"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"),
                column: "slot_per_hour",
                value: 1);

            migrationBuilder.InsertData(
                schema: "appointment_service",
                table: "operational_hours",
                columns: new[] { "id", "branch_id", "close_time", "day_of_week", "open_time" },
                values: new object[,]
                {
                    { new Guid("002c3edc-11ac-4991-934c-5aee2d05e594"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("00c8fbbb-5d28-42e4-adc7-fa827c91c48e"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("012854e6-8d00-4076-b210-34227ec32bbf"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("06abf0c5-fdde-4df2-ad18-4884f53ecf8a"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("080eeac4-7c9d-4d28-a026-495fbd367130"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("0aff59bc-77fa-4ad1-bced-21fd96d4e6b3"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("0b6daaa0-5b41-4d43-8519-34ed161ea467"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("0d36c4c6-c6da-4299-a1e3-51698bb0a773"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("115c4ec0-be5d-40a3-8afd-d2750d90478e"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("11f01456-5075-465b-9278-105066819306"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("13a7a7b0-5c76-42a9-850a-ce9101c533e0"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("166596ad-5274-483f-b0d4-3ab1c247361a"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("16b7c74b-49a0-4c9e-8c3b-d947a2cbd397"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("170226ca-832e-4ad1-beae-550f4c17a090"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("19637762-6745-4f78-8cc0-bce97471faa3"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("1b46df59-865d-40d6-85f6-9c4ff10fd543"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("1c245154-c721-46d2-8c3d-e78a96cea6d9"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("1d20adcf-6906-463d-aa47-9e1a0950cb8d"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("2076fc6e-7b58-4fdb-b5f3-dcbfc58f1f1a"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("21e44831-76f4-480d-afb1-b7824f430432"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("22461b22-8244-4881-9b6a-6a91989db593"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("22754110-8fbb-4000-9dac-85066596690a"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("25c7c784-b5c9-4441-9e54-be36cb44dc6c"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("28600809-b527-4ba4-9729-5731bf394f20"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("3046060b-c701-4cbe-a4b7-d24915947020"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("30bbb92a-97de-44a6-aed1-6c55b76a990e"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("318dd8bb-644b-4eb5-8891-c9d1990f0b1f"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("334ce1d9-1d6a-4770-b8c7-ef9aeade786d"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("34204d1c-3c92-41fa-961f-8ac0cf9a72f2"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("3437000e-218b-488d-9d7b-6e2095a836ab"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("38f91c9b-8a89-4cb1-9255-7f57218ad52b"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("394ea754-ba0e-4168-9d57-b59e56c7ad8d"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("3be1602c-3fa3-4d40-b5cf-93ff03295602"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("3daeb276-bff5-4427-9133-5ddea26aa68e"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("40c42b7f-05ee-4fd3-b68d-9b3114847ac9"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("4282ef5c-8e51-4d50-9dc5-6de96cb9dbcc"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("4725fb81-6b41-4bd5-8240-557c1f619668"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("4b41f55c-fe8a-415c-b6c4-043c251f1a52"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("503cb288-1336-4c48-a524-e5ea926027e6"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("560b623e-b842-4824-a20b-84a69d217711"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("5655cb4e-bc4b-46dd-88b9-a9c69c45699a"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("5a5ee1be-c350-47ef-b84d-8cd90ed6ede9"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("5ab4fee0-8b93-4071-a8f1-e4807b2fe679"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("5c5cc201-10f0-472d-a5e1-2e15784283af"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("600eb7d2-2e54-4228-b84d-efca6ab6ae6f"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("61553f3c-a64c-4fe7-a22e-1ab9b2c4e472"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("61b7115f-fe66-4f59-99bc-8438571b9187"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("628a9add-9c89-4dc2-af9e-fa85c1603346"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("62c8d24f-b224-4598-8d82-e9423d06155a"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("6891aae4-4f7e-4bf9-8d4d-587667ae7529"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("6cf03a8f-84a2-4ecd-8971-f9675dda7eec"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("6f633364-7d4a-49f4-9ed4-cad21a0f0445"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 17, 0, 0, 0), 0, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("6f71a4d4-fd1a-43b4-a2aa-edb485a18c75"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("70223ac6-94c7-49bb-8cde-304553bba0a7"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("711b731c-3215-405d-8e11-16220f26ab2b"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("71c1f72e-7dab-465f-8a98-c68e47fbcf64"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("720fe261-8ed8-476a-8d9f-31f5ef5019fd"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 19, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("7782f8db-aa38-4b9f-b8fe-dc00f63f6711"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("7e483dc1-8bc0-4aec-b396-cb02a0bff7e4"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("82ea5dee-b8c1-466a-a725-30a8ddc94cc9"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("8322e6f0-126c-4010-9675-a229ff54be1e"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("8365656c-d286-4961-9781-61c707fead52"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("837c25a5-b4d1-4044-904a-197d2577c5e7"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("889e068a-cd0c-4202-881a-67ae168510b7"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("88b0490a-11f8-4a0a-88bc-d48c924f3d44"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("8a75faad-5147-4e60-b36b-382947621837"), new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("8afb2b4e-bc85-4c9b-976b-4695c72d95f3"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("8c703371-15da-4080-9256-c0c30d32a663"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("8e6bbce4-a58b-4561-a90a-c6227f5dff0d"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("91c3f3a6-5be0-4704-8afa-e5cd9747c00c"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("91de8ec7-a193-4fb8-b605-354a7a39cf18"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("95fba0bb-a5ca-4ea6-9f59-e176830c05ad"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("96a38731-abfe-42e0-a5be-dfaa5a8c888d"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("9b33b5ed-9ad4-4ab7-a49b-d4f7142837a9"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 19, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("9cb5b3f8-df3e-489c-8eb7-bab1c3c6e605"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 19, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("9cbc9e9d-177e-4e47-a3dc-ae75f7a0ba02"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("9cc9240e-4063-4815-a397-b30c95dc2f43"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("9cdad90a-1341-47d1-b7e0-38f4a0ce34c8"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("9d9f2cf5-b01e-4e47-ae0e-14d67f4ba34d"), new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("a5fe4a91-80ae-41cc-a6ba-57cbbec63947"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("a8b7df51-8aaa-4213-898c-4002cc74d5ed"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 19, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("a96fa616-9a6e-4c3b-bf64-f3745a234f57"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("ab293326-3449-4f42-b346-98d8a003be33"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("b07bf468-f7b1-4627-8f63-6e169a58d6de"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("b5a651fd-1300-4637-a7e3-90389aff873b"), new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"), new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("b5e12ad3-40e3-4c44-96a3-79f55b944c0d"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("b7c265b7-f3f9-461b-bcfc-35813ea30240"), new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("babcabff-ff7a-432b-ab84-68c6063e3c89"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("bc67bf77-ac6f-4908-8548-fabf6305a2ad"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("be743536-089f-41d5-82d7-e9211d4896d0"), new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"), new TimeSpan(0, 19, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c127d683-e1f1-44e9-b8d0-2a5fb5b5fcc0"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c20f045d-3e19-4b61-9fb9-b5c3931f90e1"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c22ac067-a3ab-4941-b45c-ab850f2654c2"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new TimeSpan(0, 17, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("c2bc2c73-b94c-4fe4-85a5-81290e01d936"), new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c448673a-3513-407e-92ec-8df726b1320f"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c554b8a3-4387-4d2f-a0bb-65a24f04bb3b"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 19, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c6194e94-831e-4802-b5cd-4913f896a45e"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("c81c2137-2619-4c23-8ef0-5d63b28f7388"), new Guid("0d819742-cd02-467c-9116-210baf093806"), new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("cca7ee24-96ab-4dca-a4e9-d971210c1fd5"), new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("d14fd8ab-5042-4ade-aea9-d275c9f5f143"), new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"), new TimeSpan(0, 19, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("d931936f-feb8-47f2-b80d-10996223d778"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("dad57ec7-d155-43fb-bff2-7c46d638436e"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("db72d7dc-fd95-422e-9261-afad8845326e"), new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("de09311e-1e85-418f-aa0d-d5ae1bb42f3f"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 18, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("df28c826-2d42-43c4-a11e-3c360d19e86c"), new Guid("57fe6395-7c23-4be9-8b3d-1005fd926294"), new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("e3c9a041-cf1e-4be2-af45-f1739b8eec1b"), new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("e49a9435-be60-44a2-9fbb-2897fe33b775"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("e6595ace-50a7-45af-9dde-4b178ff67008"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 19, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("e74b637a-2c70-4e48-b486-bd1e32489de2"), new Guid("e003b6cf-613d-4e2c-b1e5-ed3f5e5ce837"), new TimeSpan(0, 19, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("e9a5059c-6db2-4bc1-bdba-db739639a083"), new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"), new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("e9e559eb-7e1c-4daf-ac88-b0cea915f4ce"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 18, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("eaf637ed-065a-4d45-a436-1f7795eb03de"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("ef045f03-d3cb-4324-9f8d-2ee682f4431a"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("ef10e666-291c-49a8-b541-c92dd51dec9f"), new Guid("dc547b0e-fb2a-4cb6-bd25-4c5b5d031e17"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("f57c536d-65c7-4198-b85f-3f915b0255c1"), new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("f6c2866f-f9cd-434c-a410-bb45d7559f95"), new Guid("9a3bfefa-1e48-452b-a533-ce951fcc1de3"), new TimeSpan(0, 14, 0, 0, 0), 6, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("f7ec0509-f28a-4d7e-8dd1-a183c2fbdb4b"), new Guid("5510587c-cda4-400b-92df-00940212c02d"), new TimeSpan(0, 18, 0, 0, 0), 5, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("fd68a21a-ddee-419b-85b0-41a526cc40f7"), new Guid("2786bf11-426a-4450-83e3-f0356c929273"), new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("ff6539b9-8a57-4258-b6b9-3d88eb27ff23"), new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"), new TimeSpan(0, 18, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                schema: "appointment_service",
                table: "customer_info",
                columns: new[] { "appointment_request_id", "contact_number", "email", "full_name", "id_number", "notes" },
                values: new object[,]
                {
                    { new Guid("000a889f-9ffd-451e-8400-54d3969db426"), "0706969240", "sipho.van der merwe@example.com", "Sipho Van der Merwe", "9712228792000", "" },
                    { new Guid("03ce31f1-7ca5-4aec-830b-7795127c6ea4"), "0799658490", "anele.govender@example.com", "Anele Govender", "9110234721100", "Home loan inquiry" },
                    { new Guid("03e2c7d3-7386-4368-bbc4-e471254b6780"), "0671543234", "lindiwe.dlamini@example.com", "Lindiwe Dlamini", "7308031045100", "" },
                    { new Guid("04ce35c7-c4eb-4342-8d6b-f1f0344c2370"), "0769358518", "naledi.jacobs@example.com", "Naledi Jacobs", "9903091097000", "" },
                    { new Guid("059402a7-00b0-46c8-9041-33d412389870"), "0838007009", "kagiso.smith@example.com", "Kagiso Smith", "7210219262100", "Home loan inquiry" },
                    { new Guid("073c0b66-5a14-43f1-bfaa-4e0a26d5ea8d"), "0835383845", "thabo.dlamini@example.com", "Thabo Dlamini", "9104094015000", "Home loan inquiry" },
                    { new Guid("074197db-c049-49ad-be52-3f07506f18df"), "0743421379", "sipho.dlamini@example.com", "Sipho Dlamini", "9305236291000", "Home loan inquiry" },
                    { new Guid("07d787f0-e3ea-4d7b-b16c-8af4e447c65f"), "0689893002", "kagiso.nkosi@example.com", "Kagiso Nkosi", "9806058006100", "" },
                    { new Guid("087224d2-7917-4698-ba6a-7e3a8dd0e63b"), "0729399227", "tumelo.nkosi@example.com", "Tumelo Nkosi", "9403241084100", "" },
                    { new Guid("09afc615-7181-4e5d-9453-ed0d752d405e"), "0757579666", "zinhle.pillay@example.com", "Zinhle Pillay", "8709151390000", "Open new account" },
                    { new Guid("0a444997-c7c2-4670-9d67-e4b3826aa62d"), "0675256224", "bongani.van der merwe@example.com", "Bongani Van der Merwe", "9905117583100", "" },
                    { new Guid("0a8c1911-3d41-4df4-a5a7-b9dc56a427b3"), "0624262748", "zinhle.botha@example.com", "Zinhle Botha", "7404029142100", "" },
                    { new Guid("0baa0ab2-df95-497c-a179-95c5a914a627"), "0738097425", "anele.govender@example.com", "Anele Govender", "7203012928000", "" },
                    { new Guid("0bd2c81d-337d-4698-957b-144f9ed9c694"), "0714722964", "bongani.mokoena@example.com", "Bongani Mokoena", "8601182860100", "" },
                    { new Guid("0c5566d9-9f23-4e12-9df9-f8b8c7d1b3cd"), "0704416408", "kagiso.jacobs@example.com", "Kagiso Jacobs", "9201048035000", "" },
                    { new Guid("0c706b02-daa0-4f0e-9d0f-8b2ce17e4bc3"), "0686619982", "naledi.dlamini@example.com", "Naledi Dlamini", "7802228947000", "" },
                    { new Guid("0d6a4701-dde9-4fdb-b96b-865833d46422"), "0749971733", "bongani.mokoena@example.com", "Bongani Mokoena", "9903083879000", "" },
                    { new Guid("0d7bdb2f-34c0-4619-893d-06a48cd95f73"), "0722290466", "bongani.nkosi@example.com", "Bongani Nkosi", "8810264150000", "" },
                    { new Guid("0d983d2d-9b6f-49f4-a8e6-250ec962f3f0"), "0761847081", "anele.dlamini@example.com", "Anele Dlamini", "9304151451000", "" },
                    { new Guid("0def0d56-139b-4735-b4e1-e81e208263cf"), "0676825689", "lerato.pillay@example.com", "Lerato Pillay", "9508083503100", "" },
                    { new Guid("0fd5db95-91f3-44ef-a197-ce384f99ee7f"), "0757169769", "bongani.smith@example.com", "Bongani Smith", "8301134594100", "Home loan inquiry" },
                    { new Guid("121a3289-9fb9-4100-9e65-40010cedc888"), "0698619038", "tumelo.botha@example.com", "Tumelo Botha", "9703195173100", "Home loan inquiry" },
                    { new Guid("12f01143-f456-46a8-91d5-0ed1c49bbb54"), "0624469120", "tumelo.botha@example.com", "Tumelo Botha", "7006051805100", "Lost ID book" },
                    { new Guid("14a83535-88ed-4f92-a8a4-b0505e876ab7"), "0712323028", "lerato.van der merwe@example.com", "Lerato Van der Merwe", "7810198292100", "Lost ID book" },
                    { new Guid("14c70f49-0213-4f62-b1ed-de30aedddbc4"), "0709090207", "lerato.van der merwe@example.com", "Lerato Van der Merwe", "9110271307100", "" },
                    { new Guid("180f0959-cd56-4dc6-a6b0-8878d6b313df"), "0839162715", "bongani.dlamini@example.com", "Bongani Dlamini", "8902106014100", "" },
                    { new Guid("1868b44e-f17a-414f-a252-da5f387aaed7"), "0681486818", "kagiso.nkosi@example.com", "Kagiso Nkosi", "7811159807100", "Open new account" },
                    { new Guid("18ffa0b5-bb47-4651-a999-bd5d35d28bf2"), "0654740836", "kagiso.govender@example.com", "Kagiso Govender", "8402049784000", "" },
                    { new Guid("19bc264b-3cf1-4c57-ae01-c80a525e510f"), "0744523013", "lindiwe.dlamini@example.com", "Lindiwe Dlamini", "7807167411000", "" },
                    { new Guid("19fe168a-0c50-4bc1-b1b7-a6226658f995"), "0687699653", "naledi.jacobs@example.com", "Naledi Jacobs", "9001051248000", "" },
                    { new Guid("1a816255-847b-478b-b8d3-0e81754e8c84"), "0779896413", "sipho.van der merwe@example.com", "Sipho Van der Merwe", "8001069997000", "Lost ID book" },
                    { new Guid("1b2b5ed2-c08e-432a-a042-71df0045e35f"), "0838935052", "bongani.smith@example.com", "Bongani Smith", "8807023550100", "" },
                    { new Guid("1b517727-c4c5-44e5-af23-754f5466bb8d"), "0682398925", "sipho.botha@example.com", "Sipho Botha", "7812101005100", "Lost ID book" },
                    { new Guid("1b58344b-508f-4ff4-846d-ff22e50781c8"), "0811540978", "naledi.smith@example.com", "Naledi Smith", "9211276076000", "" },
                    { new Guid("1b58f02f-124a-4c29-94f6-ad46a9012f1f"), "0773966974", "kagiso.jacobs@example.com", "Kagiso Jacobs", "9401208055000", "" },
                    { new Guid("1b7e092a-e425-4660-b01b-50513e1606fb"), "0838401009", "bongani.jacobs@example.com", "Bongani Jacobs", "9603105879100", "" },
                    { new Guid("1c34c833-bb5f-4045-809e-b0724a8418c9"), "0813204331", "kagiso.pillay@example.com", "Kagiso Pillay", "8106034827000", "Lost ID book" },
                    { new Guid("1c4d6367-a2d8-45dc-8b39-176f24629b2b"), "0835313241", "zinhle.mokoena@example.com", "Zinhle Mokoena", "9912216341000", "" },
                    { new Guid("1da7f0c2-6bb2-4dc4-9217-1291f1555381"), "0828529150", "thabo.van der merwe@example.com", "Thabo Van der Merwe", "7204241722100", "Open new account" },
                    { new Guid("1e52fde9-090d-458f-9fe4-4be040784c69"), "0837734566", "lerato.dlamini@example.com", "Lerato Dlamini", "8802123044000", "Open new account" },
                    { new Guid("2059e01d-de89-4a86-850b-ff78b585a4ed"), "0846444545", "lindiwe.nkosi@example.com", "Lindiwe Nkosi", "8106181389000", "" },
                    { new Guid("21112705-9235-4bfb-8de5-ebaf1ce5acb5"), "0835164236", "sipho.mokoena@example.com", "Sipho Mokoena", "8703238238100", "" },
                    { new Guid("2114b709-1564-445d-a5ca-ca7b217ad380"), "0846421825", "lerato.dlamini@example.com", "Lerato Dlamini", "7911022263000", "" },
                    { new Guid("22761405-93ce-4ea1-9dfe-8de6b52829f6"), "0719310014", "sipho.pillay@example.com", "Sipho Pillay", "9101103026100", "Open new account" },
                    { new Guid("24739870-6712-465c-bf88-3926c546e780"), "0814588595", "kagiso.dlamini@example.com", "Kagiso Dlamini", "9401144009000", "Lost ID book" },
                    { new Guid("24bead0e-dd0c-40e6-8d6c-830c12125748"), "0709723944", "tumelo.smith@example.com", "Tumelo Smith", "9010247308000", "Open new account" },
                    { new Guid("258108b6-22ba-42b6-a9b4-e5c29ac99d2e"), "0829722729", "kagiso.botha@example.com", "Kagiso Botha", "9610269486000", "Lost ID book" },
                    { new Guid("2590391a-97e5-454b-9732-5a52aec76b03"), "0611981501", "bongani.botha@example.com", "Bongani Botha", "8908235544000", "" },
                    { new Guid("2594ab6d-6a1d-4d4c-92a7-617e78386970"), "0647585900", "bongani.pillay@example.com", "Bongani Pillay", "9702039292000", "Home loan inquiry" },
                    { new Guid("26174ed3-6ea7-464d-aa5d-e22635129b60"), "0666856726", "lerato.smith@example.com", "Lerato Smith", "7709185973000", "" },
                    { new Guid("2683e1bd-3777-418f-b045-58fbb1981914"), "0811628669", "lindiwe.jacobs@example.com", "Lindiwe Jacobs", "9309084166100", "" },
                    { new Guid("26872035-9b0b-4988-b916-8ff0a123bad5"), "0758578082", "bongani.dlamini@example.com", "Bongani Dlamini", "8212205817100", "" },
                    { new Guid("27ec395c-96dc-40e6-b043-74f51f7837a6"), "0656304454", "thabo.nkosi@example.com", "Thabo Nkosi", "8211223489100", "" },
                    { new Guid("283567fd-6b2f-42e2-aacf-566f6a691d29"), "0621383863", "anele.naidoo@example.com", "Anele Naidoo", "9810108609100", "Lost ID book" },
                    { new Guid("289c37b8-9673-4239-8aed-dc0d91411f4d"), "0701348600", "zinhle.dlamini@example.com", "Zinhle Dlamini", "7601187439000", "" },
                    { new Guid("28eebef2-4cb1-4e0a-8829-bc6138bc5d41"), "0805996888", "tumelo.dlamini@example.com", "Tumelo Dlamini", "9311076476000", "" },
                    { new Guid("29ba74ca-49e8-4025-8482-d291722d52a4"), "0617749243", "tumelo.nkosi@example.com", "Tumelo Nkosi", "7807208790000", "Lost ID book" },
                    { new Guid("29be5e4f-be95-4c5e-a45c-d04fad095c2e"), "0622860649", "sipho.mokoena@example.com", "Sipho Mokoena", "8003065546000", "" },
                    { new Guid("29dce466-84c6-44bb-8515-0ef518375849"), "0836881301", "lindiwe.nkosi@example.com", "Lindiwe Nkosi", "7404168748000", "" },
                    { new Guid("2a12038b-892a-4ca6-955e-8a04bbcea8c4"), "0825194227", "anele.mokoena@example.com", "Anele Mokoena", "7612044421000", "" },
                    { new Guid("2a9134cf-de3a-445a-8c06-fc64224849c1"), "0687315555", "thabo.pillay@example.com", "Thabo Pillay", "7312018348000", "Home loan inquiry" },
                    { new Guid("2b37c7d0-2bcb-41d8-8496-9814251099f3"), "0808050648", "lerato.smith@example.com", "Lerato Smith", "9411028456000", "" },
                    { new Guid("2d0af977-aaee-42a0-9b86-0217349cc1a0"), "0652451120", "zinhle.naidoo@example.com", "Zinhle Naidoo", "8302158451000", "Home loan inquiry" },
                    { new Guid("2e0b6d4f-7216-4346-b993-3a0631c31d88"), "0738112447", "anele.botha@example.com", "Anele Botha", "8512223107000", "Open new account" },
                    { new Guid("2e1c7c1a-033f-41f3-82d7-771c6fb40fab"), "0613490509", "naledi.pillay@example.com", "Naledi Pillay", "9107146694100", "" },
                    { new Guid("2e581802-1b42-472d-bd1f-e5fc38fbd8f9"), "0762969233", "anele.govender@example.com", "Anele Govender", "9903098280100", "Open new account" },
                    { new Guid("2ef59a17-db1c-4267-9df8-0634f7d1f3fa"), "0631635831", "kagiso.jacobs@example.com", "Kagiso Jacobs", "9501054544000", "Home loan inquiry" },
                    { new Guid("2f2d3ffd-c8a8-4059-b5cf-14151cd0c58c"), "0814188624", "thabo.mokoena@example.com", "Thabo Mokoena", "8504237662100", "" },
                    { new Guid("2fee2cf1-1f9f-49e2-96ae-2968b4c2f7db"), "0727686592", "zinhle.smith@example.com", "Zinhle Smith", "7803072127100", "" },
                    { new Guid("3041e751-ad99-4edf-a50b-1c1f7a75f75b"), "0752804782", "lindiwe.dlamini@example.com", "Lindiwe Dlamini", "9211246626000", "" },
                    { new Guid("316a6687-d301-4104-a313-cc6d3fc63d4c"), "0805778793", "kagiso.jacobs@example.com", "Kagiso Jacobs", "9709063061100", "" },
                    { new Guid("31c441df-2bdd-427c-a641-c9485058f311"), "0732091832", "naledi.mokoena@example.com", "Naledi Mokoena", "8701069682000", "" },
                    { new Guid("321ff8ae-f663-4117-8ad9-b9f603ad08c8"), "0671694386", "kagiso.van der merwe@example.com", "Kagiso Van der Merwe", "7804077914100", "Lost ID book" },
                    { new Guid("34926054-fdb5-4a2d-baef-724201432d17"), "0735760918", "zinhle.dlamini@example.com", "Zinhle Dlamini", "7106234921100", "" },
                    { new Guid("34ade93b-72cb-46fc-b350-1fb7fb3f7b93"), "0744799925", "naledi.jacobs@example.com", "Naledi Jacobs", "7003081346000", "Home loan inquiry" },
                    { new Guid("3542117a-b197-4c55-b3bb-069ac8f5929f"), "0765974250", "naledi.mokoena@example.com", "Naledi Mokoena", "9412148537000", "" },
                    { new Guid("35775eec-ded1-4c8c-a0e8-c18767a71906"), "0717328819", "lindiwe.govender@example.com", "Lindiwe Govender", "8811175914000", "" },
                    { new Guid("368c45ca-7532-4c6f-909a-37166f869c50"), "0744347456", "sipho.botha@example.com", "Sipho Botha", "8307079502000", "" },
                    { new Guid("36bad877-0514-4ba0-a39c-6abc81f6bf2f"), "0672148169", "lerato.van der merwe@example.com", "Lerato Van der Merwe", "8510212357000", "" },
                    { new Guid("376c4759-3bc5-48fb-8b0e-2d93e30c3247"), "0793034404", "lerato.naidoo@example.com", "Lerato Naidoo", "8910186708000", "" },
                    { new Guid("38f03aa0-8f50-4678-8857-8628b1a2c177"), "0609545823", "sipho.mokoena@example.com", "Sipho Mokoena", "7804106726000", "" },
                    { new Guid("3af16e01-b93f-4a37-ab79-9b90289f4868"), "0821875084", "tumelo.botha@example.com", "Tumelo Botha", "8801016572100", "" },
                    { new Guid("3b62e50c-ca45-4789-aaa3-99e173a76217"), "0609714230", "naledi.naidoo@example.com", "Naledi Naidoo", "7309014189000", "" },
                    { new Guid("3ca17bed-c61f-4fa9-9754-447d6d104b0e"), "0628179492", "kagiso.botha@example.com", "Kagiso Botha", "9311268300100", "" },
                    { new Guid("3e2fc51b-3fb4-4712-a149-af1c182a9ff8"), "0621018307", "kagiso.smith@example.com", "Kagiso Smith", "9901262607000", "" },
                    { new Guid("40a7426e-f7ad-4f98-acd4-0da99924cedb"), "0668938556", "bongani.mokoena@example.com", "Bongani Mokoena", "7103092543000", "" },
                    { new Guid("413d27d3-9952-40d9-9ab1-22d7abbce589"), "0798279167", "thabo.botha@example.com", "Thabo Botha", "8401229426000", "Open new account" },
                    { new Guid("41a52192-60dc-4364-86f5-c5286a4ff4ee"), "0811763378", "naledi.van der merwe@example.com", "Naledi Van der Merwe", "7304192505100", "" },
                    { new Guid("424762c1-2077-43d9-a6f5-ecee63cfee07"), "0844030138", "sipho.govender@example.com", "Sipho Govender", "8905063497100", "" },
                    { new Guid("427a4f97-bdc6-4a7d-a8e7-45c06e107952"), "0818981066", "lindiwe.naidoo@example.com", "Lindiwe Naidoo", "8104255757000", "" },
                    { new Guid("44a303e1-21b9-465e-bdb0-fa7e934bbaab"), "0685340472", "kagiso.nkosi@example.com", "Kagiso Nkosi", "7107156135100", "" },
                    { new Guid("44f59567-d587-4b7b-9681-88ea188545c2"), "0811677743", "tumelo.govender@example.com", "Tumelo Govender", "8611273630000", "" },
                    { new Guid("44f9e94a-8ef1-429c-8477-5956832c4e15"), "0803440821", "anele.smith@example.com", "Anele Smith", "8911251155000", "Home loan inquiry" },
                    { new Guid("4564f744-c107-494b-9585-4e41af673c9a"), "0778012859", "bongani.botha@example.com", "Bongani Botha", "8007263696100", "" },
                    { new Guid("4639ae6d-774c-4eb7-946e-41e0e61bc5f9"), "0831712994", "bongani.nkosi@example.com", "Bongani Nkosi", "8105151875000", "" },
                    { new Guid("46e2c2ee-8b06-4db3-a358-5d9486f15766"), "0815151834", "kagiso.mokoena@example.com", "Kagiso Mokoena", "9912171116000", "Lost ID book" },
                    { new Guid("471b2a8d-5abb-4258-b321-297e093af845"), "0819109506", "tumelo.mokoena@example.com", "Tumelo Mokoena", "9804042366000", "Open new account" },
                    { new Guid("476d6bdf-1e71-4a7c-9935-26f3d48378d7"), "0826280649", "naledi.dlamini@example.com", "Naledi Dlamini", "8310154605000", "" },
                    { new Guid("47ee3890-c53d-4908-92e3-ff39dce40130"), "0799075807", "kagiso.jacobs@example.com", "Kagiso Jacobs", "7604215320100", "" },
                    { new Guid("481bbe5f-8a14-4e36-9116-a45464278763"), "0829634343", "sipho.pillay@example.com", "Sipho Pillay", "7604185724100", "Home loan inquiry" },
                    { new Guid("4947bd1a-20f0-4c27-a70b-6670fbfcb0dd"), "0614377987", "sipho.mokoena@example.com", "Sipho Mokoena", "8608117156000", "Open new account" },
                    { new Guid("4a0d02d9-ad3b-4126-aff1-be5b35c6af00"), "0707147600", "tumelo.smith@example.com", "Tumelo Smith", "9811016296100", "Open new account" },
                    { new Guid("4bbc8b6a-a7bf-4799-85b0-4313d04c0014"), "0705668182", "bongani.dlamini@example.com", "Bongani Dlamini", "9402014179000", "" },
                    { new Guid("4c65493c-a6c2-4c7e-b9e4-b947ec2ac68a"), "0821148509", "bongani.mokoena@example.com", "Bongani Mokoena", "8411099273100", "Lost ID book" },
                    { new Guid("4cb409ae-f21f-4837-aa63-900975742f12"), "0671661367", "naledi.govender@example.com", "Naledi Govender", "8912111660100", "Lost ID book" },
                    { new Guid("4d4a0cc0-d60f-433b-a55e-b7687b347c40"), "0843136542", "zinhle.mokoena@example.com", "Zinhle Mokoena", "7302131532000", "" },
                    { new Guid("4defb677-5c55-43c2-83b3-e374e216fa8b"), "0655453223", "naledi.pillay@example.com", "Naledi Pillay", "7312084455000", "" },
                    { new Guid("4e3a13ca-86f3-4b90-ae19-0e82ec7b008d"), "0711136387", "naledi.smith@example.com", "Naledi Smith", "8311199753100", "" },
                    { new Guid("4ec5f547-6675-41e1-ba3d-a9bb5ee0b3cb"), "0631811013", "naledi.nkosi@example.com", "Naledi Nkosi", "8501226194000", "" },
                    { new Guid("4ec80506-23d4-42b0-a0ec-af612265301c"), "0685698479", "lerato.govender@example.com", "Lerato Govender", "8403213834100", "" },
                    { new Guid("4f39e1a3-1b2f-4fca-b2b1-a8b2be2b39e2"), "0631331137", "bongani.jacobs@example.com", "Bongani Jacobs", "8702252214100", "" },
                    { new Guid("4f81b3b2-a264-40fe-88e6-659e75cbfa92"), "0712836970", "tumelo.pillay@example.com", "Tumelo Pillay", "8411128412000", "" },
                    { new Guid("4fb3921b-a692-4b77-8421-f88ec676c3dd"), "0631576264", "sipho.van der merwe@example.com", "Sipho Van der Merwe", "8804124470000", "" },
                    { new Guid("50496808-9b93-4661-83eb-d15dfdac7056"), "0794290432", "lindiwe.jacobs@example.com", "Lindiwe Jacobs", "9507269055000", "Lost ID book" },
                    { new Guid("51d80f6c-2b16-417f-89cf-d912e9cbbdb6"), "0613075674", "lindiwe.naidoo@example.com", "Lindiwe Naidoo", "8104234247000", "" },
                    { new Guid("51e6080c-728d-4e5a-b5df-05417fd43847"), "0688144193", "kagiso.nkosi@example.com", "Kagiso Nkosi", "8909068496000", "Lost ID book" },
                    { new Guid("52486575-4105-438e-b809-c99b4189aaa6"), "0849696252", "zinhle.jacobs@example.com", "Zinhle Jacobs", "9102125354000", "Open new account" },
                    { new Guid("547ea4b2-dbd0-4ddb-97e9-cf24763bb6da"), "0714587770", "anele.nkosi@example.com", "Anele Nkosi", "7803112615000", "" },
                    { new Guid("55b7f7f7-1970-43af-ac8f-a53beace83a9"), "0714874426", "lerato.dlamini@example.com", "Lerato Dlamini", "9909114801000", "" },
                    { new Guid("568f7343-4f09-43bf-9aa8-3a3d5dc51811"), "0815414337", "thabo.van der merwe@example.com", "Thabo Van der Merwe", "8405216678000", "" },
                    { new Guid("57222e73-91f2-413c-8dac-a3dc21f4d097"), "0694980623", "thabo.botha@example.com", "Thabo Botha", "8308059321100", "" },
                    { new Guid("57796a87-9011-49a7-b691-7c39dc6861e0"), "0648340512", "naledi.smith@example.com", "Naledi Smith", "9004237794000", "Home loan inquiry" },
                    { new Guid("57f03ef2-0215-4529-83ce-a14f312f443b"), "0728515949", "lindiwe.mokoena@example.com", "Lindiwe Mokoena", "9605026967100", "" },
                    { new Guid("58474d07-052e-4e7e-b9c6-795141c54c07"), "0734329023", "tumelo.van der merwe@example.com", "Tumelo Van der Merwe", "8502088212100", "Home loan inquiry" },
                    { new Guid("5a49b010-7de4-47f4-a011-55a28ade205d"), "0709512057", "naledi.mokoena@example.com", "Naledi Mokoena", "7511191881000", "Open new account" },
                    { new Guid("5a9e9d0c-a293-4dd2-8d4f-c83494bb7b26"), "0765118395", "zinhle.van der merwe@example.com", "Zinhle Van der Merwe", "7104147300000", "Open new account" },
                    { new Guid("5afffb5f-0fa9-4d1d-9aa4-aac82a2fa849"), "0747027000", "anele.jacobs@example.com", "Anele Jacobs", "8601064858000", "" },
                    { new Guid("5b4d54d4-434c-4df8-9011-c0b2f92978ec"), "0802558307", "bongani.naidoo@example.com", "Bongani Naidoo", "8204027106000", "Lost ID book" },
                    { new Guid("5ba2b145-987b-4649-b2a8-6a38a0896b8b"), "0758452903", "lerato.naidoo@example.com", "Lerato Naidoo", "8108202830000", "" },
                    { new Guid("5c5c5cd6-4274-460a-8b20-8e3c36b5ab96"), "0755936890", "anele.pillay@example.com", "Anele Pillay", "7006033766100", "" },
                    { new Guid("5c64ee4a-fc48-4d80-a3a4-a434a6574bac"), "0763544510", "lindiwe.dlamini@example.com", "Lindiwe Dlamini", "8808137886000", "" },
                    { new Guid("5c849c47-22a2-4f2e-93b7-46c8f0940be2"), "0736642721", "lindiwe.nkosi@example.com", "Lindiwe Nkosi", "7901082916100", "" },
                    { new Guid("5d03bc1f-709a-403b-8d8c-4915f3377a94"), "0661504903", "tumelo.botha@example.com", "Tumelo Botha", "9308012801000", "Home loan inquiry" },
                    { new Guid("5d0e6c50-02db-4d7b-9908-e72cc6a2539d"), "0728236841", "bongani.smith@example.com", "Bongani Smith", "8305236057000", "" },
                    { new Guid("5e60c1ab-c73b-4f61-af6b-0b74ff08f69e"), "0745244471", "thabo.botha@example.com", "Thabo Botha", "8705141491100", "Open new account" },
                    { new Guid("5ec93ebc-2bc0-4a5c-8fc5-5bb8c9a3233f"), "0655017016", "anele.naidoo@example.com", "Anele Naidoo", "7110119771100", "" },
                    { new Guid("5f373d3c-9094-4d6f-8590-a391d722e25c"), "0791602643", "anele.govender@example.com", "Anele Govender", "7208143221100", "" },
                    { new Guid("60017284-c9d1-4106-ae85-35fd72249c0a"), "0842714248", "naledi.nkosi@example.com", "Naledi Nkosi", "9502034026000", "Open new account" },
                    { new Guid("606a3f7f-9c6f-4761-8704-a5bf8add09e6"), "0664433185", "bongani.govender@example.com", "Bongani Govender", "8402117981000", "" },
                    { new Guid("60b769c5-1fc7-468a-829f-0c0b8133beee"), "0807918342", "zinhle.smith@example.com", "Zinhle Smith", "9906231476000", "" },
                    { new Guid("616c3748-7363-49c5-ba53-7d6e68b073f0"), "0647023688", "zinhle.mokoena@example.com", "Zinhle Mokoena", "7011012885100", "Home loan inquiry" },
                    { new Guid("61aec1bb-dee8-4953-8e50-cdb437ea9c34"), "0803726299", "tumelo.dlamini@example.com", "Tumelo Dlamini", "9501029873100", "" },
                    { new Guid("62be3e89-41a4-4090-9212-ca346d1c9468"), "0672042206", "zinhle.nkosi@example.com", "Zinhle Nkosi", "9210271615000", "Open new account" },
                    { new Guid("62e0f79f-314c-42d3-ae7f-f983b73f304e"), "0626984612", "zinhle.botha@example.com", "Zinhle Botha", "8904214102100", "" },
                    { new Guid("632c556b-59d4-446a-adbc-4b054f49f3b6"), "0798267606", "zinhle.govender@example.com", "Zinhle Govender", "8604159600000", "Open new account" },
                    { new Guid("633b4e38-adfe-41eb-98d1-8e356251df1e"), "0748414328", "anele.van der merwe@example.com", "Anele Van der Merwe", "9609206451100", "Lost ID book" },
                    { new Guid("635d35c6-d5c7-4429-99bf-d7d7746e8e8e"), "0705570551", "tumelo.naidoo@example.com", "Tumelo Naidoo", "7804195078100", "" },
                    { new Guid("656d8e4a-65a0-40a9-85fd-2e2a790d8ca0"), "0813242889", "lerato.pillay@example.com", "Lerato Pillay", "8810219349000", "Lost ID book" },
                    { new Guid("65d01b5f-1831-42b9-a029-389beec88082"), "0618668334", "lerato.pillay@example.com", "Lerato Pillay", "7301088049000", "" },
                    { new Guid("660d6a9a-470f-488a-8201-b35c46846deb"), "0828515666", "kagiso.govender@example.com", "Kagiso Govender", "9410099143000", "" },
                    { new Guid("670ca4ee-e919-4c4c-84c6-a40627aa168c"), "0693712332", "lindiwe.pillay@example.com", "Lindiwe Pillay", "8208108325100", "" },
                    { new Guid("683b23a9-c0b7-4813-a786-0273264cd0e8"), "0686668725", "naledi.dlamini@example.com", "Naledi Dlamini", "7309053419100", "Open new account" },
                    { new Guid("686cd665-4524-469a-bc1c-4bd2d2511227"), "0704781399", "anele.govender@example.com", "Anele Govender", "8312148734000", "Lost ID book" },
                    { new Guid("6901707b-ca1e-4f68-8a47-f285b1d2feac"), "0641751055", "naledi.pillay@example.com", "Naledi Pillay", "7212215536100", "Open new account" },
                    { new Guid("6a396a21-f3dd-42b6-b257-e0526be6e702"), "0781316211", "kagiso.van der merwe@example.com", "Kagiso Van der Merwe", "7611011827000", "" },
                    { new Guid("6aea5333-a431-4002-9dcf-8aac5244d7ad"), "0687067721", "lindiwe.smith@example.com", "Lindiwe Smith", "9502076777100", "" },
                    { new Guid("6b458b1e-ad06-4bfc-aff4-b1b2dfe3ee29"), "0686958812", "lindiwe.naidoo@example.com", "Lindiwe Naidoo", "7511186764100", "" },
                    { new Guid("6c948f21-f9d7-40b9-9d10-a04e024b6ea0"), "0796638106", "anele.botha@example.com", "Anele Botha", "9205051237000", "Open new account" },
                    { new Guid("6cb9c018-f36e-4db6-935d-2634e501910c"), "0811220542", "lerato.naidoo@example.com", "Lerato Naidoo", "7506206703000", "Open new account" },
                    { new Guid("6db68e3f-8a5d-4b58-88bd-006adf07e4d7"), "0725143034", "sipho.van der merwe@example.com", "Sipho Van der Merwe", "9905255802100", "" },
                    { new Guid("6f563eb9-2ff2-41a6-96dd-55fee040a7d6"), "0668385494", "tumelo.jacobs@example.com", "Tumelo Jacobs", "9410129160000", "" },
                    { new Guid("6f784dd5-4b16-48ad-947a-08eb981a0d81"), "0831045558", "kagiso.nkosi@example.com", "Kagiso Nkosi", "7805143146100", "" },
                    { new Guid("700e04ad-81bc-4e41-99e1-dcd33d45765a"), "0795236268", "tumelo.jacobs@example.com", "Tumelo Jacobs", "8601244772000", "Open new account" },
                    { new Guid("71bb0210-7b03-4ccb-90e7-5913ce9c9f9d"), "0815900109", "thabo.dlamini@example.com", "Thabo Dlamini", "8103266465000", "Lost ID book" },
                    { new Guid("72a3bc0d-82f6-445f-a89e-dc3d31f65f79"), "0727909356", "kagiso.dlamini@example.com", "Kagiso Dlamini", "7508046485100", "Open new account" },
                    { new Guid("72b736a8-8408-459f-975e-5965a07374f4"), "0676248441", "tumelo.dlamini@example.com", "Tumelo Dlamini", "9709142677000", "" },
                    { new Guid("730d9ec6-b5d6-428e-94dd-aeaec9ef8491"), "0607586511", "zinhle.nkosi@example.com", "Zinhle Nkosi", "8604164305100", "" },
                    { new Guid("73159a53-bf9e-402c-82ca-29196d3aea50"), "0795812906", "lerato.mokoena@example.com", "Lerato Mokoena", "7410065426100", "" },
                    { new Guid("73683764-b00f-4c9a-b1ea-07d6cb5b4097"), "0776656172", "zinhle.dlamini@example.com", "Zinhle Dlamini", "7108141457000", "Open new account" },
                    { new Guid("73d12bdc-238e-45ec-aa3a-fc24982492a6"), "0676812735", "lerato.naidoo@example.com", "Lerato Naidoo", "8908022214100", "Home loan inquiry" },
                    { new Guid("74070cde-7f43-4c2c-805a-bcc445f5b38d"), "0829436099", "bongani.nkosi@example.com", "Bongani Nkosi", "9102266515000", "" },
                    { new Guid("74e77f21-05b0-4e70-820a-e90a8ec55791"), "0834763956", "thabo.mokoena@example.com", "Thabo Mokoena", "7405129599000", "Open new account" },
                    { new Guid("760c74d7-62bd-477b-8a84-1720a96d82d9"), "0744817780", "lindiwe.mokoena@example.com", "Lindiwe Mokoena", "8212175927000", "" },
                    { new Guid("765a9b2c-2da5-4d61-b25b-cacc3fa8a63a"), "0648172358", "bongani.smith@example.com", "Bongani Smith", "7906204725000", "" },
                    { new Guid("7717b54f-cd1f-4dd5-9004-306ef3891e41"), "0716123140", "anele.botha@example.com", "Anele Botha", "8503172832100", "Open new account" },
                    { new Guid("773ea1d7-f8bf-4c95-b8d6-1620c878eb78"), "0794346230", "kagiso.botha@example.com", "Kagiso Botha", "8205163181100", "" },
                    { new Guid("77ec435b-d398-4ab3-a9bd-30993f3dd81c"), "0608194783", "sipho.naidoo@example.com", "Sipho Naidoo", "7208165416100", "" },
                    { new Guid("786682b1-9f19-45a9-97ee-b1dbaaaecaf1"), "0695259946", "anele.govender@example.com", "Anele Govender", "8703219640000", "" },
                    { new Guid("78c4cbe5-209a-4536-ba54-c376db3c5d06"), "0802758751", "zinhle.dlamini@example.com", "Zinhle Dlamini", "9912185560000", "" },
                    { new Guid("78dd6168-7df7-4fd7-9786-0c422b745b92"), "0694183928", "anele.pillay@example.com", "Anele Pillay", "8112107862000", "" },
                    { new Guid("78ff43c0-2a33-4ae8-a258-879fa32997fa"), "0659401153", "anele.pillay@example.com", "Anele Pillay", "8803092647000", "" },
                    { new Guid("79fa0585-320a-4ded-9c6c-9ba029bd03ea"), "0675798608", "anele.smith@example.com", "Anele Smith", "8602223969100", "" },
                    { new Guid("7cad554e-0d80-46a6-be9c-afdd8882a56c"), "0753363498", "lerato.govender@example.com", "Lerato Govender", "8107139868000", "" },
                    { new Guid("7db83cbe-db2c-47fa-823d-f89dd486c83f"), "0821242376", "lindiwe.jacobs@example.com", "Lindiwe Jacobs", "9001112691000", "" },
                    { new Guid("7e1e7d10-10d9-4bc2-ba10-2e5760e1a55d"), "0713875641", "kagiso.van der merwe@example.com", "Kagiso Van der Merwe", "7409237799100", "Open new account" },
                    { new Guid("7e293435-a128-4557-9d82-89593941b222"), "0713760469", "kagiso.pillay@example.com", "Kagiso Pillay", "7501145633100", "" },
                    { new Guid("7e5b7d60-8f5b-4345-adcc-f1cf1c2610ba"), "0817804876", "sipho.naidoo@example.com", "Sipho Naidoo", "8911029167000", "Lost ID book" },
                    { new Guid("7f1a3b7f-450e-4269-a5bd-536da316ab05"), "0672418584", "lindiwe.pillay@example.com", "Lindiwe Pillay", "9111141411000", "" },
                    { new Guid("7f396e67-7c29-4cfd-aab5-83ac8c9c9c2f"), "0639467255", "lindiwe.jacobs@example.com", "Lindiwe Jacobs", "8910171418100", "Lost ID book" },
                    { new Guid("7fb5f442-8d48-462c-bc91-19a3ae8f099c"), "0826457807", "tumelo.jacobs@example.com", "Tumelo Jacobs", "9010269301000", "" },
                    { new Guid("805d488b-a36c-499e-8148-182beb5d73b1"), "0687984993", "lindiwe.jacobs@example.com", "Lindiwe Jacobs", "7909051928000", "Open new account" },
                    { new Guid("8090bfc6-92ba-4551-b66f-bc82125073f7"), "0731124385", "tumelo.pillay@example.com", "Tumelo Pillay", "8508086845100", "Home loan inquiry" },
                    { new Guid("80fbdf5f-234d-4fe3-a220-115b5ea5ddcd"), "0827881304", "lindiwe.mokoena@example.com", "Lindiwe Mokoena", "8205201350100", "Home loan inquiry" },
                    { new Guid("81822ee1-a304-411a-9694-1485333a480e"), "0672497793", "lerato.dlamini@example.com", "Lerato Dlamini", "9007158035100", "" },
                    { new Guid("81846bce-da8e-4c71-bfb9-c6ab8b6a09c0"), "0703171376", "anele.jacobs@example.com", "Anele Jacobs", "9011265549100", "Lost ID book" },
                    { new Guid("82f00b23-55c3-4fd2-999a-cba36b17bcbc"), "0835150743", "lindiwe.mokoena@example.com", "Lindiwe Mokoena", "7001181310100", "" },
                    { new Guid("83e26c2a-b869-4abe-b0c0-2fef02cd61c6"), "0621371735", "naledi.van der merwe@example.com", "Naledi Van der Merwe", "9607249639100", "" },
                    { new Guid("865b0916-6a49-4331-862e-4c2d5664b76b"), "0762406263", "tumelo.van der merwe@example.com", "Tumelo Van der Merwe", "7405172390100", "" },
                    { new Guid("871c7551-8f69-416b-b91f-449d137de89d"), "0822732011", "thabo.mokoena@example.com", "Thabo Mokoena", "7712171860100", "" },
                    { new Guid("884e1d46-e865-4733-bd4e-8703aadec435"), "0699037879", "bongani.dlamini@example.com", "Bongani Dlamini", "9203141903100", "" },
                    { new Guid("88ace37b-e6b8-4fea-a02b-9fef55fe4c55"), "0729634785", "anele.naidoo@example.com", "Anele Naidoo", "9411226441100", "Lost ID book" },
                    { new Guid("893c0b41-37e5-4937-bb36-78d9024b4589"), "0801220480", "bongani.jacobs@example.com", "Bongani Jacobs", "7403162230100", "" },
                    { new Guid("8a054ddf-b329-486e-8f73-90337ac2d329"), "0614777783", "tumelo.mokoena@example.com", "Tumelo Mokoena", "8705278564000", "" },
                    { new Guid("8c2cece1-aded-4b0d-89c7-baa87a45af68"), "0663056597", "naledi.naidoo@example.com", "Naledi Naidoo", "9403246979000", "" },
                    { new Guid("8cd403f2-e844-4c20-91e6-e13480d1167c"), "0825388845", "lindiwe.jacobs@example.com", "Lindiwe Jacobs", "8107124147000", "Open new account" },
                    { new Guid("8e435f6e-ed5a-41e3-8840-e8a64a8640c9"), "0667349141", "sipho.naidoo@example.com", "Sipho Naidoo", "9904101113100", "" },
                    { new Guid("8e4d3fb8-61ca-4b10-93b8-6ff818bb496a"), "0737904561", "bongani.smith@example.com", "Bongani Smith", "8604219157100", "" },
                    { new Guid("8f3d2c21-d8c8-4f79-8a8d-85d1cb223e70"), "0837847530", "zinhle.dlamini@example.com", "Zinhle Dlamini", "8911121238100", "" },
                    { new Guid("8fd2b12d-5776-4895-9d3c-40be97c3d807"), "0689043614", "lindiwe.mokoena@example.com", "Lindiwe Mokoena", "7603137961100", "Home loan inquiry" },
                    { new Guid("90ee9245-2c58-4e6a-a746-14ada87ed91b"), "0756167768", "thabo.jacobs@example.com", "Thabo Jacobs", "7105242364000", "" },
                    { new Guid("90fee299-dc67-4a0c-945f-9fac9ab860d4"), "0734016939", "kagiso.botha@example.com", "Kagiso Botha", "7710038464000", "" },
                    { new Guid("9140e21a-5187-4379-9dbe-46497d9afe3c"), "0722953303", "lerato.naidoo@example.com", "Lerato Naidoo", "7210096109000", "Open new account" },
                    { new Guid("93069726-28bf-48c0-87fa-8324fc5d226d"), "0762907910", "bongani.naidoo@example.com", "Bongani Naidoo", "7407074651000", "" },
                    { new Guid("93639d82-96c3-4008-ab51-74b30fe35225"), "0793566972", "thabo.van der merwe@example.com", "Thabo Van der Merwe", "7706024141000", "" },
                    { new Guid("94db7c18-e1ed-4317-bf73-ba835df4a61d"), "0749023797", "zinhle.pillay@example.com", "Zinhle Pillay", "8205184414000", "" },
                    { new Guid("95e801a1-77e5-4d73-8c29-f075302914bb"), "0768391763", "lindiwe.pillay@example.com", "Lindiwe Pillay", "8610151697100", "" },
                    { new Guid("9614ce83-bcdc-4c03-9962-f1355d534ec6"), "0793868670", "sipho.govender@example.com", "Sipho Govender", "7711222655100", "Open new account" },
                    { new Guid("96538f02-9ea4-4f99-9263-3ff9c74e2c17"), "0652925158", "zinhle.nkosi@example.com", "Zinhle Nkosi", "7506022114000", "" },
                    { new Guid("967c47e7-2409-496b-ba2b-43e5c3dfe7b3"), "0686537892", "bongani.dlamini@example.com", "Bongani Dlamini", "8903186871100", "" },
                    { new Guid("96d38851-8d5e-45f1-a0fd-2c776d112e74"), "0816450430", "tumelo.van der merwe@example.com", "Tumelo Van der Merwe", "9107087837100", "" },
                    { new Guid("97006098-9f4b-459c-89ca-a220da7e3474"), "0758589714", "thabo.smith@example.com", "Thabo Smith", "8412273345100", "Open new account" },
                    { new Guid("974875a6-b866-4e4a-a9f9-0e35633de0e0"), "0803487251", "lindiwe.pillay@example.com", "Lindiwe Pillay", "9902147260000", "" },
                    { new Guid("974c8e0e-c469-4a45-9674-c4c4dacefa6d"), "0628929950", "bongani.botha@example.com", "Bongani Botha", "7107166448000", "Home loan inquiry" },
                    { new Guid("984229df-e3b2-40ac-8638-7133115a9846"), "0666432103", "lindiwe.jacobs@example.com", "Lindiwe Jacobs", "8310219362100", "" },
                    { new Guid("9894d8d1-018c-44c8-88b8-309ffa217a7b"), "0759656090", "naledi.nkosi@example.com", "Naledi Nkosi", "9712225707100", "Home loan inquiry" },
                    { new Guid("9a4d25fe-2f9a-4c8c-ba2a-ea54bb725322"), "0781277808", "lindiwe.smith@example.com", "Lindiwe Smith", "9008273665100", "" },
                    { new Guid("9afc79a3-444a-4653-806a-58d0d162d77d"), "0605446950", "sipho.govender@example.com", "Sipho Govender", "9901067099100", "" },
                    { new Guid("9b1ac5c3-6cd7-4bf2-9743-36646592b9f7"), "0819164526", "tumelo.mokoena@example.com", "Tumelo Mokoena", "8701193011000", "" },
                    { new Guid("9baa0571-8bd9-42c8-8cb4-f660f84539e2"), "0666761998", "sipho.van der merwe@example.com", "Sipho Van der Merwe", "8203224850000", "" },
                    { new Guid("9c279c68-d3b0-4c69-8d25-139fab7ed87e"), "0673883434", "lindiwe.pillay@example.com", "Lindiwe Pillay", "8802092330000", "" },
                    { new Guid("9cd507c7-a12c-4c03-b637-e85468e81ecc"), "0644375154", "lerato.botha@example.com", "Lerato Botha", "7004232063100", "Open new account" },
                    { new Guid("9d9e6ffa-ae23-4d74-8e02-9e1b71dcc330"), "0707903987", "bongani.pillay@example.com", "Bongani Pillay", "9408192223100", "" },
                    { new Guid("9e5dff47-748d-435f-94ff-0adf0ea2884c"), "0754060391", "naledi.jacobs@example.com", "Naledi Jacobs", "8009145759000", "" },
                    { new Guid("9ee07345-8222-4646-83ad-21634f718f7f"), "0808136424", "thabo.nkosi@example.com", "Thabo Nkosi", "7104243072100", "Open new account" },
                    { new Guid("a0a88a5e-bbec-4b39-9d79-a2fa74401c42"), "0691316819", "bongani.nkosi@example.com", "Bongani Nkosi", "9307033790100", "" },
                    { new Guid("a160228a-7649-4a35-b70a-825764be1431"), "0809426476", "kagiso.naidoo@example.com", "Kagiso Naidoo", "8802164418000", "" },
                    { new Guid("a25fe8d9-104c-4217-9284-716b9aff1d27"), "0753897194", "zinhle.naidoo@example.com", "Zinhle Naidoo", "8005066445100", "" },
                    { new Guid("a292b883-d9dd-4b19-b4ec-df13e68958ee"), "0747834937", "kagiso.naidoo@example.com", "Kagiso Naidoo", "7402246779100", "" },
                    { new Guid("a2b0cb2e-f5a4-4b6b-8ff6-a23b931ed563"), "0632663758", "lindiwe.dlamini@example.com", "Lindiwe Dlamini", "9008141802100", "" },
                    { new Guid("a3294d34-3585-4b3c-8fe7-cfbc7a4c573b"), "0763328509", "bongani.mokoena@example.com", "Bongani Mokoena", "7806043193000", "" },
                    { new Guid("a32bf527-64af-4d0e-b2f8-b540d015b08d"), "0682316910", "lerato.van der merwe@example.com", "Lerato Van der Merwe", "7102016746000", "" },
                    { new Guid("a384e267-61fd-4b60-8bda-1d02c24348e1"), "0705621465", "lerato.mokoena@example.com", "Lerato Mokoena", "9101131108100", "" },
                    { new Guid("a4231ae5-829a-4210-8c1f-b454ec5c6dd2"), "0656619264", "sipho.pillay@example.com", "Sipho Pillay", "8506138683100", "" },
                    { new Guid("a57f32d2-400b-4d1a-898d-82dfc585dffa"), "0786942569", "thabo.pillay@example.com", "Thabo Pillay", "7007049994100", "Lost ID book" },
                    { new Guid("a5cac9b9-333a-4b29-bcff-b492ad76fbb7"), "0676437110", "naledi.pillay@example.com", "Naledi Pillay", "7606177219000", "" },
                    { new Guid("a603958e-03e4-48cf-b3c3-2b0ed2b0cbca"), "0819821411", "kagiso.govender@example.com", "Kagiso Govender", "9709115549100", "Lost ID book" },
                    { new Guid("a63aff12-b635-46f1-b23c-836b1603f8b8"), "0632959966", "lerato.van der merwe@example.com", "Lerato Van der Merwe", "7908255621100", "" },
                    { new Guid("a667edf5-0a10-46f8-9c06-191a0a7ce30b"), "0819063051", "sipho.van der merwe@example.com", "Sipho Van der Merwe", "7910231081000", "Home loan inquiry" },
                    { new Guid("a67759ba-103b-4952-883a-0a106819b550"), "0714064535", "kagiso.nkosi@example.com", "Kagiso Nkosi", "8511095664000", "" },
                    { new Guid("a7073c71-2f5d-493b-bd81-ac6389ea13e0"), "0739908456", "anele.naidoo@example.com", "Anele Naidoo", "9910197433000", "" },
                    { new Guid("a717535b-da52-4406-9304-1f560f928e9a"), "0797341727", "naledi.govender@example.com", "Naledi Govender", "8509144003100", "" },
                    { new Guid("a94c4f0d-0246-4aef-8786-c675cf71d220"), "0846967503", "kagiso.mokoena@example.com", "Kagiso Mokoena", "7311229186100", "" },
                    { new Guid("a9882254-dae6-4c9f-bdc0-7cb68ae3d085"), "0712903965", "anele.van der merwe@example.com", "Anele Van der Merwe", "7607195085100", "" },
                    { new Guid("a9d56366-03c7-414b-a9df-ffa69aa24811"), "0691477180", "bongani.smith@example.com", "Bongani Smith", "9710016595000", "Lost ID book" },
                    { new Guid("aa544b88-8608-41e2-be8b-5b2e30c5a0c1"), "0729460291", "lerato.smith@example.com", "Lerato Smith", "9205136719100", "Open new account" },
                    { new Guid("aab97681-632b-4c2a-9da3-631da07b33c6"), "0712040078", "zinhle.van der merwe@example.com", "Zinhle Van der Merwe", "8305248507100", "" },
                    { new Guid("abf94f91-edd7-4b72-865a-9ed6c9071baf"), "0816577107", "lerato.mokoena@example.com", "Lerato Mokoena", "8302059579100", "Open new account" },
                    { new Guid("aca7fa8d-767c-4412-96bd-be35aa8ae05a"), "0803083444", "bongani.nkosi@example.com", "Bongani Nkosi", "8702258679000", "" },
                    { new Guid("ae585b00-ca39-4c57-8912-3d538d874c24"), "0678079228", "lerato.naidoo@example.com", "Lerato Naidoo", "7704154696100", "" },
                    { new Guid("aefd7dcb-fea6-4f43-b09d-749a0dbcb104"), "0627293740", "lerato.pillay@example.com", "Lerato Pillay", "7409186558100", "" },
                    { new Guid("af8859be-ad5f-428d-96a5-9bb3b5fcc935"), "0673547335", "zinhle.govender@example.com", "Zinhle Govender", "7102099061000", "" },
                    { new Guid("afc5aadb-a043-48f7-a595-8e24eb304d93"), "0799081855", "anele.dlamini@example.com", "Anele Dlamini", "9612214086100", "" },
                    { new Guid("b01b8172-ff95-41b1-9ce0-6678b8839e61"), "0812353560", "zinhle.smith@example.com", "Zinhle Smith", "9309061443000", "" },
                    { new Guid("b02d7c4a-64ea-4e87-b789-a8d4240c76dc"), "0652558746", "lerato.jacobs@example.com", "Lerato Jacobs", "8910119681000", "" },
                    { new Guid("b13999f8-94eb-4258-bc2f-4d9e99e1bdb8"), "0646513606", "anele.dlamini@example.com", "Anele Dlamini", "7110259745100", "" },
                    { new Guid("b1d3f625-52c3-455a-904d-dc8a55afc320"), "0793111295", "sipho.naidoo@example.com", "Sipho Naidoo", "7504205615000", "Lost ID book" },
                    { new Guid("b228461e-a668-4365-b482-ef3de38801e0"), "0846188927", "thabo.govender@example.com", "Thabo Govender", "7609136947100", "" },
                    { new Guid("b2bded2f-b45e-493c-840b-89c3f9230cf9"), "0736689383", "anele.jacobs@example.com", "Anele Jacobs", "9209062026100", "" },
                    { new Guid("b36bddb9-957a-453c-80f2-536274d5746e"), "0821300968", "lerato.smith@example.com", "Lerato Smith", "8711135553000", "Lost ID book" },
                    { new Guid("b44b07e2-83dd-4c98-8905-9368ba932479"), "0606705740", "thabo.naidoo@example.com", "Thabo Naidoo", "9004037105100", "" },
                    { new Guid("b48c6830-9c44-47aa-8905-7f967dbf28d1"), "0717207847", "naledi.pillay@example.com", "Naledi Pillay", "8312148995000", "" },
                    { new Guid("b522bf8b-5cb0-4767-99a5-77b6e1c75ab4"), "0722248784", "anele.smith@example.com", "Anele Smith", "9309163061000", "" },
                    { new Guid("b8295c3b-3aa4-4d04-a624-7b27ef6fae7c"), "0678745692", "kagiso.mokoena@example.com", "Kagiso Mokoena", "7701113628100", "Open new account" },
                    { new Guid("b90b188c-bc5e-47ab-8f6d-3dbd1fa8a5e9"), "0694776720", "zinhle.mokoena@example.com", "Zinhle Mokoena", "7707227862000", "" },
                    { new Guid("b95cfc3f-bb3a-4d75-a7d0-55eaeed6b30e"), "0746535286", "tumelo.botha@example.com", "Tumelo Botha", "9707123011100", "Open new account" },
                    { new Guid("ba274730-5d3c-4963-b869-48801656f55e"), "0812787354", "zinhle.pillay@example.com", "Zinhle Pillay", "8911258084000", "" },
                    { new Guid("ba61b783-a836-4957-8802-29fcab2dd35c"), "0807849930", "kagiso.dlamini@example.com", "Kagiso Dlamini", "9701125891000", "" },
                    { new Guid("bb05cfde-c54e-404e-a6ec-ca575bcbe80f"), "0633700528", "anele.smith@example.com", "Anele Smith", "9104142400000", "" },
                    { new Guid("bb2b0fa4-ee6e-4650-a36d-4bc4bea7c8c5"), "0732562013", "naledi.botha@example.com", "Naledi Botha", "9904249301000", "" },
                    { new Guid("bbbb6643-1f6c-4eb4-87bb-a2c9a591a45d"), "0834513619", "anele.van der merwe@example.com", "Anele Van der Merwe", "7612154092000", "Open new account" },
                    { new Guid("bc955bd4-cbba-4c35-b063-4ca5c5f46c42"), "0679492938", "zinhle.van der merwe@example.com", "Zinhle Van der Merwe", "9112033678100", "" },
                    { new Guid("bd5bc840-4e19-4614-b0f6-158d7da3ea20"), "0778280520", "thabo.mokoena@example.com", "Thabo Mokoena", "9109209965100", "" },
                    { new Guid("bd68a502-164d-4380-8d90-ba21457b2fba"), "0634151352", "tumelo.naidoo@example.com", "Tumelo Naidoo", "8007158091000", "" },
                    { new Guid("bd771dfc-21ce-412e-b81e-071d7818c47f"), "0806028416", "tumelo.dlamini@example.com", "Tumelo Dlamini", "8805113082100", "" },
                    { new Guid("bdb6254e-d88b-49ea-bf4b-1d05d1dd9ca6"), "0636644896", "sipho.dlamini@example.com", "Sipho Dlamini", "8407105215100", "" },
                    { new Guid("be522b80-6bb4-4bfb-a7dc-fd2fcda6995c"), "0717795061", "sipho.dlamini@example.com", "Sipho Dlamini", "8412224120100", "Home loan inquiry" },
                    { new Guid("bf0a3b6b-d48a-4a47-bce5-9335d67f7e63"), "0743241462", "anele.smith@example.com", "Anele Smith", "7903253554100", "Open new account" },
                    { new Guid("bf4687f0-e928-422b-b2d1-d96621b58ca0"), "0669288108", "kagiso.jacobs@example.com", "Kagiso Jacobs", "8611116140000", "Lost ID book" },
                    { new Guid("bffa2168-6284-46c1-b364-28cc19a3f464"), "0775556021", "zinhle.jacobs@example.com", "Zinhle Jacobs", "9902058398100", "" },
                    { new Guid("c040f632-b68a-4f6d-985d-eade20bdd34a"), "0609555623", "anele.naidoo@example.com", "Anele Naidoo", "7509257310000", "" },
                    { new Guid("c0c33498-5559-4652-8e83-74c6a7406bb3"), "0602636691", "bongani.smith@example.com", "Bongani Smith", "8612222154000", "" },
                    { new Guid("c1473d9f-c07f-4466-9f66-27255feddcc8"), "0669701850", "tumelo.van der merwe@example.com", "Tumelo Van der Merwe", "8301179499000", "" },
                    { new Guid("c19c0641-a582-4c6b-bfaf-108c8e5fce95"), "0659249657", "naledi.dlamini@example.com", "Naledi Dlamini", "8102016875000", "" },
                    { new Guid("c1bd813e-7986-41fd-a861-a50b04abe596"), "0663858732", "naledi.mokoena@example.com", "Naledi Mokoena", "8701113915000", "" },
                    { new Guid("c1fbeafc-663a-4a5a-aa2a-2e24bdcaa753"), "0747043831", "lindiwe.mokoena@example.com", "Lindiwe Mokoena", "8301241382000", "" },
                    { new Guid("c31091d4-6154-433a-9d04-baf92987268a"), "0647694699", "lerato.van der merwe@example.com", "Lerato Van der Merwe", "8309242458000", "" },
                    { new Guid("c4b7d8c1-8066-44f3-940d-f26c9099f793"), "0818242702", "bongani.botha@example.com", "Bongani Botha", "7404239679000", "" },
                    { new Guid("c4bc4652-9182-4fce-a3cb-8dadc99848e3"), "0649061680", "tumelo.nkosi@example.com", "Tumelo Nkosi", "7902232057100", "" },
                    { new Guid("c7084e5e-6358-4663-bb31-c998314bdbf4"), "0642177164", "lerato.van der merwe@example.com", "Lerato Van der Merwe", "9205131162100", "" },
                    { new Guid("c7b06ba7-044b-4961-8130-5f09a3853e5d"), "0694418334", "lindiwe.botha@example.com", "Lindiwe Botha", "9206185003100", "" },
                    { new Guid("c7cd0270-8395-4f57-be4d-156caf841a05"), "0754102303", "naledi.botha@example.com", "Naledi Botha", "9412259700100", "" },
                    { new Guid("c88c12f4-0428-4b7a-8a20-8e303f6bedd7"), "0782803858", "zinhle.naidoo@example.com", "Zinhle Naidoo", "9102224130100", "" },
                    { new Guid("cbddb3b5-5fe6-4288-a0cf-addeb300ef52"), "0642758553", "anele.pillay@example.com", "Anele Pillay", "9512149213000", "" },
                    { new Guid("cc6603cd-5780-482d-b444-0f4d92ef0e2e"), "0649442577", "kagiso.govender@example.com", "Kagiso Govender", "8912108708000", "" },
                    { new Guid("cf6dc8e9-f8c5-40e5-b29a-ee02c9dbfa45"), "0833819463", "thabo.nkosi@example.com", "Thabo Nkosi", "7504147659100", "Lost ID book" },
                    { new Guid("d09feec7-a5e5-4e87-8081-8438c6944aef"), "0773030365", "tumelo.naidoo@example.com", "Tumelo Naidoo", "8609126891100", "" },
                    { new Guid("d0d78557-b4c0-4675-bc36-ee6d39fe466f"), "0847770066", "lerato.jacobs@example.com", "Lerato Jacobs", "7103222065100", "" },
                    { new Guid("d1507355-e277-46ae-bbb9-718e634d2305"), "0705039446", "bongani.naidoo@example.com", "Bongani Naidoo", "8603267221000", "Open new account" },
                    { new Guid("d16c8244-d01a-4083-b54b-2479329a3982"), "0812317835", "zinhle.smith@example.com", "Zinhle Smith", "8306237134000", "" },
                    { new Guid("d1854a11-4a09-4d8a-883b-cfaa3ba5ae81"), "0657659632", "bongani.jacobs@example.com", "Bongani Jacobs", "9801036963000", "" },
                    { new Guid("d3f892ac-01ed-4e70-b044-160c96e969f5"), "0726546598", "lerato.mokoena@example.com", "Lerato Mokoena", "9310132416000", "" },
                    { new Guid("d46a2eef-b40a-4bbd-831b-86fe7b3892f5"), "0655023240", "tumelo.dlamini@example.com", "Tumelo Dlamini", "9512157255000", "Lost ID book" },
                    { new Guid("d559eaae-c856-4d7e-9449-29c76890aa45"), "0636044917", "lindiwe.naidoo@example.com", "Lindiwe Naidoo", "7101013376100", "" },
                    { new Guid("d5ca0ef0-e42b-48bf-b44b-b3e8684dc80a"), "0752436895", "bongani.smith@example.com", "Bongani Smith", "7707102068100", "Lost ID book" },
                    { new Guid("d7796a30-fb8b-4574-8fd2-58bc08f63e8c"), "0749331654", "zinhle.mokoena@example.com", "Zinhle Mokoena", "7706017054000", "" },
                    { new Guid("d830d78e-819d-421d-a172-543f21dd2c76"), "0683088319", "kagiso.pillay@example.com", "Kagiso Pillay", "8710122998100", "Open new account" },
                    { new Guid("d8bc6421-b3bc-45c3-b02a-a7e50c0fbb84"), "0696152585", "zinhle.pillay@example.com", "Zinhle Pillay", "7108225409100", "" },
                    { new Guid("d90f7a0a-2448-4154-b368-65409d632de4"), "0706620382", "naledi.van der merwe@example.com", "Naledi Van der Merwe", "8112077835000", "" },
                    { new Guid("da0cd0d8-7b7a-4b47-b075-157997ae68ff"), "0766779454", "lindiwe.naidoo@example.com", "Lindiwe Naidoo", "8312184305100", "Lost ID book" },
                    { new Guid("da25231d-bbd4-45bf-9525-9dc546af1748"), "0701202445", "lindiwe.govender@example.com", "Lindiwe Govender", "9905068099000", "" },
                    { new Guid("da312297-79e2-4fd8-b3de-2b0365d05a68"), "0831325740", "anele.govender@example.com", "Anele Govender", "9307021766100", "" },
                    { new Guid("daaca9c2-c54b-4ba0-a047-169d2ce4f8cc"), "0789582806", "tumelo.van der merwe@example.com", "Tumelo Van der Merwe", "7407123076100", "" },
                    { new Guid("db6e177b-4f66-4d42-b49f-afdd14b345d4"), "0842822151", "tumelo.nkosi@example.com", "Tumelo Nkosi", "7206188021000", "" },
                    { new Guid("dc4b3ccd-c78b-4ece-9749-b42784d49e73"), "0843181127", "thabo.mokoena@example.com", "Thabo Mokoena", "8507212221000", "" },
                    { new Guid("dd7b4ff9-adab-4975-a68c-3ebca6c4de47"), "0742697844", "lerato.van der merwe@example.com", "Lerato Van der Merwe", "8905095174100", "" },
                    { new Guid("dda0b761-dc19-4d23-9e14-a6ac71220f39"), "0635178724", "anele.pillay@example.com", "Anele Pillay", "7902067718000", "" },
                    { new Guid("ddd00cdc-1993-437b-83f7-0af44ddd6edf"), "0627354857", "bongani.mokoena@example.com", "Bongani Mokoena", "7601071438100", "Open new account" },
                    { new Guid("df481487-20e3-43a4-be87-ecbf38f7941b"), "0703946017", "kagiso.mokoena@example.com", "Kagiso Mokoena", "9201218389100", "" },
                    { new Guid("e01635c4-422a-46bb-ae49-17981f0a51d6"), "0789317381", "zinhle.jacobs@example.com", "Zinhle Jacobs", "9101037298100", "Home loan inquiry" },
                    { new Guid("e139397c-11b4-441f-b891-a888e7b5a068"), "0786765319", "tumelo.govender@example.com", "Tumelo Govender", "9301041158100", "Home loan inquiry" },
                    { new Guid("e199c07b-eac9-4f07-90c1-db23c11fc958"), "0684247584", "bongani.jacobs@example.com", "Bongani Jacobs", "8407028704100", "" },
                    { new Guid("e3968c95-0e40-4ccd-90f3-e2f8f64704bc"), "0669730309", "sipho.nkosi@example.com", "Sipho Nkosi", "9202171764100", "" },
                    { new Guid("e3f2ed2d-b198-4eed-8fb0-b91d636adccd"), "0662238938", "tumelo.naidoo@example.com", "Tumelo Naidoo", "8401121992100", "" },
                    { new Guid("e510417d-dfa1-417a-83e6-f2ad45f2fe99"), "0736558923", "thabo.govender@example.com", "Thabo Govender", "8904064773000", "" },
                    { new Guid("e5b6d2a5-1449-4011-b983-808a24938779"), "0685607020", "thabo.naidoo@example.com", "Thabo Naidoo", "8704203568000", "Open new account" },
                    { new Guid("e758bdc4-dc58-4cca-b95d-4eaf4f619feb"), "0847008133", "lerato.smith@example.com", "Lerato Smith", "9808262705000", "" },
                    { new Guid("e7e07eab-74af-4297-8b74-7167a7b2c732"), "0741653968", "naledi.govender@example.com", "Naledi Govender", "7802168283000", "Lost ID book" },
                    { new Guid("e94b5c16-0ab3-474a-bacd-ed08aa8ca795"), "0797926723", "bongani.pillay@example.com", "Bongani Pillay", "7604211374000", "" },
                    { new Guid("e96f6ece-7a6f-4e46-8520-efd4a2781ceb"), "0814315381", "anele.pillay@example.com", "Anele Pillay", "7801189666000", "" },
                    { new Guid("eba91117-f8c8-4add-a041-3ebd844738d8"), "0838336887", "lindiwe.naidoo@example.com", "Lindiwe Naidoo", "9408131528000", "" },
                    { new Guid("ec6e4847-95ae-4e18-8dff-a1c3d7c292a1"), "0818489557", "zinhle.govender@example.com", "Zinhle Govender", "9202167511100", "Home loan inquiry" },
                    { new Guid("ed094942-60b4-43c9-8ae4-c874a3e595f3"), "0698816754", "tumelo.mokoena@example.com", "Tumelo Mokoena", "8904019895100", "" },
                    { new Guid("ed2231c2-b84f-40bb-a47b-2d8f3121f6f4"), "0843334836", "lindiwe.dlamini@example.com", "Lindiwe Dlamini", "8406055207000", "" },
                    { new Guid("ed40bab9-4e5e-48e6-91b3-44af6c6e2716"), "0628323880", "lerato.pillay@example.com", "Lerato Pillay", "8307124450100", "Lost ID book" },
                    { new Guid("ee6030de-3d96-4ee1-b22c-a8706d291eeb"), "0816279494", "lindiwe.van der merwe@example.com", "Lindiwe Van der Merwe", "9201111627100", "Lost ID book" },
                    { new Guid("ee6bf6a8-c5e1-41a0-83b1-f4c275857b3f"), "0722652948", "kagiso.naidoo@example.com", "Kagiso Naidoo", "7304221865000", "" },
                    { new Guid("ee95da7d-7901-4e30-ab19-68445894ed9e"), "0808805177", "zinhle.smith@example.com", "Zinhle Smith", "9302095087000", "" },
                    { new Guid("eebcf1c5-3f7d-438d-b378-39b468ded7dc"), "0841591263", "thabo.dlamini@example.com", "Thabo Dlamini", "9807202293100", "Lost ID book" },
                    { new Guid("ef248f66-b634-4a5d-b451-e59be15ed0ee"), "0833109281", "anele.van der merwe@example.com", "Anele Van der Merwe", "8611239337100", "" },
                    { new Guid("f01eea17-5c1b-4650-8472-71ab442a49ef"), "0614288098", "zinhle.naidoo@example.com", "Zinhle Naidoo", "9202271121100", "" },
                    { new Guid("f0cd0c94-670b-42b5-aab1-30927bf3efc3"), "0826106156", "sipho.pillay@example.com", "Sipho Pillay", "8806035581100", "" },
                    { new Guid("f17d9ade-2eae-4d94-850d-6880723b86a2"), "0609754921", "tumelo.van der merwe@example.com", "Tumelo Van der Merwe", "7503019340000", "Open new account" },
                    { new Guid("f1e6ee23-7f98-4e0c-bfe2-d2f9be858ae7"), "0829108391", "lindiwe.dlamini@example.com", "Lindiwe Dlamini", "8206094656000", "Home loan inquiry" },
                    { new Guid("f31df194-a7ff-4570-a089-f0482762037c"), "0724540269", "anele.naidoo@example.com", "Anele Naidoo", "9110095929000", "Home loan inquiry" },
                    { new Guid("f3a918ed-3b0d-4a1e-b127-4ab45ee96c0c"), "0691233041", "bongani.govender@example.com", "Bongani Govender", "7611127346100", "" },
                    { new Guid("f406198e-4c1e-493b-bb9e-3d900f81f27f"), "0787804530", "zinhle.nkosi@example.com", "Zinhle Nkosi", "8601247901000", "" },
                    { new Guid("f47444ce-6bef-450b-a3d7-481ea419cb2b"), "0774609043", "bongani.botha@example.com", "Bongani Botha", "7211278282100", "" },
                    { new Guid("f525045f-526a-4cc9-9dd8-907420eb9fc2"), "0617371845", "naledi.mokoena@example.com", "Naledi Mokoena", "8101153961100", "" },
                    { new Guid("f6d4f435-ab2f-49d2-8e67-5ab3344b22a6"), "0631034752", "sipho.govender@example.com", "Sipho Govender", "7712134637100", "" },
                    { new Guid("f79ea623-c0e9-4afa-9c1b-7a4948a13593"), "0607201095", "bongani.botha@example.com", "Bongani Botha", "7003098405100", "" },
                    { new Guid("f7f045f8-8545-4481-8a2f-023a3257da60"), "0701913239", "lindiwe.smith@example.com", "Lindiwe Smith", "9905035074100", "" },
                    { new Guid("f835c454-4b9a-4d79-8bbd-73d495568d2c"), "0798146735", "lerato.jacobs@example.com", "Lerato Jacobs", "9607177168000", "" },
                    { new Guid("fa6678e3-0438-4b82-8cf6-2594525e5d2e"), "0622282467", "lindiwe.jacobs@example.com", "Lindiwe Jacobs", "8004084685100", "" },
                    { new Guid("fa7a51d3-7012-469b-9c18-f08b51c3968d"), "0766902562", "naledi.botha@example.com", "Naledi Botha", "7009262867100", "" },
                    { new Guid("faf25b88-b97f-41e8-9818-882ea1608aaa"), "0807498956", "lindiwe.van der merwe@example.com", "Lindiwe Van der Merwe", "7606182318000", "" },
                    { new Guid("fbbb3e01-bcf3-4162-9e3e-a92cf7de942d"), "0799382936", "naledi.van der merwe@example.com", "Naledi Van der Merwe", "9406097689100", "" },
                    { new Guid("fbcd3a81-fd29-4783-9f63-7476e87b3ad2"), "0825401539", "thabo.van der merwe@example.com", "Thabo Van der Merwe", "7709269467000", "Lost ID book" },
                    { new Guid("fc6a9274-2cb3-4a2d-ac58-05f7a809a8a0"), "0633424051", "anele.jacobs@example.com", "Anele Jacobs", "9601049905000", "Open new account" },
                    { new Guid("fda1223d-791d-4118-8e5a-8674c05e0d47"), "0764102273", "sipho.mokoena@example.com", "Sipho Mokoena", "9804243148100", "" },
                    { new Guid("fde54be8-4dcb-4411-b118-08f63445ae81"), "0806665435", "sipho.naidoo@example.com", "Sipho Naidoo", "9205165046000", "" },
                    { new Guid("fe764af6-e531-4f95-9cff-6a4a3580127a"), "0713620091", "kagiso.naidoo@example.com", "Kagiso Naidoo", "7206197900000", "Lost ID book" },
                    { new Guid("fe8bc1c1-685d-4880-a4de-54a5ecdde12a"), "0636044072", "kagiso.govender@example.com", "Kagiso Govender", "9409184342000", "Lost ID book" },
                    { new Guid("ff9601d7-d166-474d-88d1-2202620dd219"), "0825611378", "lindiwe.van der merwe@example.com", "Lindiwe Van der Merwe", "9505039779000", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("000a889f-9ffd-451e-8400-54d3969db426"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("03ce31f1-7ca5-4aec-830b-7795127c6ea4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("03e2c7d3-7386-4368-bbc4-e471254b6780"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("04ce35c7-c4eb-4342-8d6b-f1f0344c2370"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("059402a7-00b0-46c8-9041-33d412389870"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("073c0b66-5a14-43f1-bfaa-4e0a26d5ea8d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("074197db-c049-49ad-be52-3f07506f18df"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("07d787f0-e3ea-4d7b-b16c-8af4e447c65f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("087224d2-7917-4698-ba6a-7e3a8dd0e63b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("09afc615-7181-4e5d-9453-ed0d752d405e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0a444997-c7c2-4670-9d67-e4b3826aa62d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0a8c1911-3d41-4df4-a5a7-b9dc56a427b3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0baa0ab2-df95-497c-a179-95c5a914a627"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0bd2c81d-337d-4698-957b-144f9ed9c694"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0c5566d9-9f23-4e12-9df9-f8b8c7d1b3cd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0c706b02-daa0-4f0e-9d0f-8b2ce17e4bc3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0d6a4701-dde9-4fdb-b96b-865833d46422"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0d7bdb2f-34c0-4619-893d-06a48cd95f73"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0d983d2d-9b6f-49f4-a8e6-250ec962f3f0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0def0d56-139b-4735-b4e1-e81e208263cf"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("0fd5db95-91f3-44ef-a197-ce384f99ee7f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("121a3289-9fb9-4100-9e65-40010cedc888"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("12f01143-f456-46a8-91d5-0ed1c49bbb54"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("14a83535-88ed-4f92-a8a4-b0505e876ab7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("14c70f49-0213-4f62-b1ed-de30aedddbc4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("180f0959-cd56-4dc6-a6b0-8878d6b313df"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1868b44e-f17a-414f-a252-da5f387aaed7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("18ffa0b5-bb47-4651-a999-bd5d35d28bf2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("19bc264b-3cf1-4c57-ae01-c80a525e510f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("19fe168a-0c50-4bc1-b1b7-a6226658f995"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1a816255-847b-478b-b8d3-0e81754e8c84"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1b2b5ed2-c08e-432a-a042-71df0045e35f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1b517727-c4c5-44e5-af23-754f5466bb8d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1b58344b-508f-4ff4-846d-ff22e50781c8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1b58f02f-124a-4c29-94f6-ad46a9012f1f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1b7e092a-e425-4660-b01b-50513e1606fb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1c34c833-bb5f-4045-809e-b0724a8418c9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1c4d6367-a2d8-45dc-8b39-176f24629b2b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1da7f0c2-6bb2-4dc4-9217-1291f1555381"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("1e52fde9-090d-458f-9fe4-4be040784c69"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2059e01d-de89-4a86-850b-ff78b585a4ed"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("21112705-9235-4bfb-8de5-ebaf1ce5acb5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2114b709-1564-445d-a5ca-ca7b217ad380"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("22761405-93ce-4ea1-9dfe-8de6b52829f6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("24739870-6712-465c-bf88-3926c546e780"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("24bead0e-dd0c-40e6-8d6c-830c12125748"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("258108b6-22ba-42b6-a9b4-e5c29ac99d2e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2590391a-97e5-454b-9732-5a52aec76b03"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2594ab6d-6a1d-4d4c-92a7-617e78386970"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("26174ed3-6ea7-464d-aa5d-e22635129b60"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2683e1bd-3777-418f-b045-58fbb1981914"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("26872035-9b0b-4988-b916-8ff0a123bad5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("27ec395c-96dc-40e6-b043-74f51f7837a6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("283567fd-6b2f-42e2-aacf-566f6a691d29"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("289c37b8-9673-4239-8aed-dc0d91411f4d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("28eebef2-4cb1-4e0a-8829-bc6138bc5d41"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("29ba74ca-49e8-4025-8482-d291722d52a4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("29be5e4f-be95-4c5e-a45c-d04fad095c2e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("29dce466-84c6-44bb-8515-0ef518375849"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2a12038b-892a-4ca6-955e-8a04bbcea8c4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2a9134cf-de3a-445a-8c06-fc64224849c1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2b37c7d0-2bcb-41d8-8496-9814251099f3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2d0af977-aaee-42a0-9b86-0217349cc1a0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2e0b6d4f-7216-4346-b993-3a0631c31d88"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2e1c7c1a-033f-41f3-82d7-771c6fb40fab"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2e581802-1b42-472d-bd1f-e5fc38fbd8f9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2ef59a17-db1c-4267-9df8-0634f7d1f3fa"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2f2d3ffd-c8a8-4059-b5cf-14151cd0c58c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("2fee2cf1-1f9f-49e2-96ae-2968b4c2f7db"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("3041e751-ad99-4edf-a50b-1c1f7a75f75b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("316a6687-d301-4104-a313-cc6d3fc63d4c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("31c441df-2bdd-427c-a641-c9485058f311"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("321ff8ae-f663-4117-8ad9-b9f603ad08c8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("34926054-fdb5-4a2d-baef-724201432d17"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("34ade93b-72cb-46fc-b350-1fb7fb3f7b93"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("3542117a-b197-4c55-b3bb-069ac8f5929f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("35775eec-ded1-4c8c-a0e8-c18767a71906"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("368c45ca-7532-4c6f-909a-37166f869c50"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("36bad877-0514-4ba0-a39c-6abc81f6bf2f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("376c4759-3bc5-48fb-8b0e-2d93e30c3247"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("38f03aa0-8f50-4678-8857-8628b1a2c177"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("3af16e01-b93f-4a37-ab79-9b90289f4868"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("3b62e50c-ca45-4789-aaa3-99e173a76217"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("3ca17bed-c61f-4fa9-9754-447d6d104b0e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("3e2fc51b-3fb4-4712-a149-af1c182a9ff8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("40a7426e-f7ad-4f98-acd4-0da99924cedb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("413d27d3-9952-40d9-9ab1-22d7abbce589"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("41a52192-60dc-4364-86f5-c5286a4ff4ee"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("424762c1-2077-43d9-a6f5-ecee63cfee07"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("427a4f97-bdc6-4a7d-a8e7-45c06e107952"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("44a303e1-21b9-465e-bdb0-fa7e934bbaab"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("44f59567-d587-4b7b-9681-88ea188545c2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("44f9e94a-8ef1-429c-8477-5956832c4e15"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4564f744-c107-494b-9585-4e41af673c9a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4639ae6d-774c-4eb7-946e-41e0e61bc5f9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("46e2c2ee-8b06-4db3-a358-5d9486f15766"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("471b2a8d-5abb-4258-b321-297e093af845"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("476d6bdf-1e71-4a7c-9935-26f3d48378d7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("47ee3890-c53d-4908-92e3-ff39dce40130"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("481bbe5f-8a14-4e36-9116-a45464278763"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4947bd1a-20f0-4c27-a70b-6670fbfcb0dd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4a0d02d9-ad3b-4126-aff1-be5b35c6af00"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4bbc8b6a-a7bf-4799-85b0-4313d04c0014"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4c65493c-a6c2-4c7e-b9e4-b947ec2ac68a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4cb409ae-f21f-4837-aa63-900975742f12"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4d4a0cc0-d60f-433b-a55e-b7687b347c40"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4defb677-5c55-43c2-83b3-e374e216fa8b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4e3a13ca-86f3-4b90-ae19-0e82ec7b008d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4ec5f547-6675-41e1-ba3d-a9bb5ee0b3cb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4ec80506-23d4-42b0-a0ec-af612265301c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4f39e1a3-1b2f-4fca-b2b1-a8b2be2b39e2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4f81b3b2-a264-40fe-88e6-659e75cbfa92"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("4fb3921b-a692-4b77-8421-f88ec676c3dd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("50496808-9b93-4661-83eb-d15dfdac7056"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("51d80f6c-2b16-417f-89cf-d912e9cbbdb6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("51e6080c-728d-4e5a-b5df-05417fd43847"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("52486575-4105-438e-b809-c99b4189aaa6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("547ea4b2-dbd0-4ddb-97e9-cf24763bb6da"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("55b7f7f7-1970-43af-ac8f-a53beace83a9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("568f7343-4f09-43bf-9aa8-3a3d5dc51811"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("57222e73-91f2-413c-8dac-a3dc21f4d097"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("57796a87-9011-49a7-b691-7c39dc6861e0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("57f03ef2-0215-4529-83ce-a14f312f443b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("58474d07-052e-4e7e-b9c6-795141c54c07"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5a49b010-7de4-47f4-a011-55a28ade205d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5a9e9d0c-a293-4dd2-8d4f-c83494bb7b26"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5afffb5f-0fa9-4d1d-9aa4-aac82a2fa849"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5b4d54d4-434c-4df8-9011-c0b2f92978ec"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5ba2b145-987b-4649-b2a8-6a38a0896b8b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5c5c5cd6-4274-460a-8b20-8e3c36b5ab96"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5c64ee4a-fc48-4d80-a3a4-a434a6574bac"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5c849c47-22a2-4f2e-93b7-46c8f0940be2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5d03bc1f-709a-403b-8d8c-4915f3377a94"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5d0e6c50-02db-4d7b-9908-e72cc6a2539d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5e60c1ab-c73b-4f61-af6b-0b74ff08f69e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5ec93ebc-2bc0-4a5c-8fc5-5bb8c9a3233f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("5f373d3c-9094-4d6f-8590-a391d722e25c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("60017284-c9d1-4106-ae85-35fd72249c0a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("606a3f7f-9c6f-4761-8704-a5bf8add09e6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("60b769c5-1fc7-468a-829f-0c0b8133beee"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("616c3748-7363-49c5-ba53-7d6e68b073f0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("61aec1bb-dee8-4953-8e50-cdb437ea9c34"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("62be3e89-41a4-4090-9212-ca346d1c9468"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("62e0f79f-314c-42d3-ae7f-f983b73f304e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("632c556b-59d4-446a-adbc-4b054f49f3b6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("633b4e38-adfe-41eb-98d1-8e356251df1e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("635d35c6-d5c7-4429-99bf-d7d7746e8e8e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("656d8e4a-65a0-40a9-85fd-2e2a790d8ca0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("65d01b5f-1831-42b9-a029-389beec88082"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("660d6a9a-470f-488a-8201-b35c46846deb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("670ca4ee-e919-4c4c-84c6-a40627aa168c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("683b23a9-c0b7-4813-a786-0273264cd0e8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("686cd665-4524-469a-bc1c-4bd2d2511227"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("6901707b-ca1e-4f68-8a47-f285b1d2feac"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("6a396a21-f3dd-42b6-b257-e0526be6e702"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("6aea5333-a431-4002-9dcf-8aac5244d7ad"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("6b458b1e-ad06-4bfc-aff4-b1b2dfe3ee29"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("6c948f21-f9d7-40b9-9d10-a04e024b6ea0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("6cb9c018-f36e-4db6-935d-2634e501910c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("6db68e3f-8a5d-4b58-88bd-006adf07e4d7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("6f563eb9-2ff2-41a6-96dd-55fee040a7d6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("6f784dd5-4b16-48ad-947a-08eb981a0d81"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("700e04ad-81bc-4e41-99e1-dcd33d45765a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("71bb0210-7b03-4ccb-90e7-5913ce9c9f9d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("72a3bc0d-82f6-445f-a89e-dc3d31f65f79"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("72b736a8-8408-459f-975e-5965a07374f4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("730d9ec6-b5d6-428e-94dd-aeaec9ef8491"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("73159a53-bf9e-402c-82ca-29196d3aea50"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("73683764-b00f-4c9a-b1ea-07d6cb5b4097"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("73d12bdc-238e-45ec-aa3a-fc24982492a6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("74070cde-7f43-4c2c-805a-bcc445f5b38d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("74e77f21-05b0-4e70-820a-e90a8ec55791"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("760c74d7-62bd-477b-8a84-1720a96d82d9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("765a9b2c-2da5-4d61-b25b-cacc3fa8a63a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("7717b54f-cd1f-4dd5-9004-306ef3891e41"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("773ea1d7-f8bf-4c95-b8d6-1620c878eb78"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("77ec435b-d398-4ab3-a9bd-30993f3dd81c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("786682b1-9f19-45a9-97ee-b1dbaaaecaf1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("78c4cbe5-209a-4536-ba54-c376db3c5d06"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("78dd6168-7df7-4fd7-9786-0c422b745b92"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("78ff43c0-2a33-4ae8-a258-879fa32997fa"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("79fa0585-320a-4ded-9c6c-9ba029bd03ea"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("7cad554e-0d80-46a6-be9c-afdd8882a56c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("7db83cbe-db2c-47fa-823d-f89dd486c83f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("7e1e7d10-10d9-4bc2-ba10-2e5760e1a55d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("7e293435-a128-4557-9d82-89593941b222"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("7e5b7d60-8f5b-4345-adcc-f1cf1c2610ba"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("7f1a3b7f-450e-4269-a5bd-536da316ab05"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("7f396e67-7c29-4cfd-aab5-83ac8c9c9c2f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("7fb5f442-8d48-462c-bc91-19a3ae8f099c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("805d488b-a36c-499e-8148-182beb5d73b1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("8090bfc6-92ba-4551-b66f-bc82125073f7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("80fbdf5f-234d-4fe3-a220-115b5ea5ddcd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("81822ee1-a304-411a-9694-1485333a480e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("81846bce-da8e-4c71-bfb9-c6ab8b6a09c0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("82f00b23-55c3-4fd2-999a-cba36b17bcbc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("83e26c2a-b869-4abe-b0c0-2fef02cd61c6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("865b0916-6a49-4331-862e-4c2d5664b76b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("871c7551-8f69-416b-b91f-449d137de89d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("884e1d46-e865-4733-bd4e-8703aadec435"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("88ace37b-e6b8-4fea-a02b-9fef55fe4c55"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("893c0b41-37e5-4937-bb36-78d9024b4589"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("8a054ddf-b329-486e-8f73-90337ac2d329"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("8c2cece1-aded-4b0d-89c7-baa87a45af68"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("8cd403f2-e844-4c20-91e6-e13480d1167c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("8e435f6e-ed5a-41e3-8840-e8a64a8640c9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("8e4d3fb8-61ca-4b10-93b8-6ff818bb496a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("8f3d2c21-d8c8-4f79-8a8d-85d1cb223e70"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("8fd2b12d-5776-4895-9d3c-40be97c3d807"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("90ee9245-2c58-4e6a-a746-14ada87ed91b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("90fee299-dc67-4a0c-945f-9fac9ab860d4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9140e21a-5187-4379-9dbe-46497d9afe3c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("93069726-28bf-48c0-87fa-8324fc5d226d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("93639d82-96c3-4008-ab51-74b30fe35225"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("94db7c18-e1ed-4317-bf73-ba835df4a61d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("95e801a1-77e5-4d73-8c29-f075302914bb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9614ce83-bcdc-4c03-9962-f1355d534ec6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("96538f02-9ea4-4f99-9263-3ff9c74e2c17"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("967c47e7-2409-496b-ba2b-43e5c3dfe7b3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("96d38851-8d5e-45f1-a0fd-2c776d112e74"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("97006098-9f4b-459c-89ca-a220da7e3474"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("974875a6-b866-4e4a-a9f9-0e35633de0e0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("974c8e0e-c469-4a45-9674-c4c4dacefa6d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("984229df-e3b2-40ac-8638-7133115a9846"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9894d8d1-018c-44c8-88b8-309ffa217a7b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9a4d25fe-2f9a-4c8c-ba2a-ea54bb725322"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9afc79a3-444a-4653-806a-58d0d162d77d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9b1ac5c3-6cd7-4bf2-9743-36646592b9f7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9baa0571-8bd9-42c8-8cb4-f660f84539e2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9c279c68-d3b0-4c69-8d25-139fab7ed87e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9cd507c7-a12c-4c03-b637-e85468e81ecc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9d9e6ffa-ae23-4d74-8e02-9e1b71dcc330"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9e5dff47-748d-435f-94ff-0adf0ea2884c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("9ee07345-8222-4646-83ad-21634f718f7f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a0a88a5e-bbec-4b39-9d79-a2fa74401c42"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a160228a-7649-4a35-b70a-825764be1431"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a25fe8d9-104c-4217-9284-716b9aff1d27"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a292b883-d9dd-4b19-b4ec-df13e68958ee"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a2b0cb2e-f5a4-4b6b-8ff6-a23b931ed563"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a3294d34-3585-4b3c-8fe7-cfbc7a4c573b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a32bf527-64af-4d0e-b2f8-b540d015b08d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a384e267-61fd-4b60-8bda-1d02c24348e1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a4231ae5-829a-4210-8c1f-b454ec5c6dd2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a57f32d2-400b-4d1a-898d-82dfc585dffa"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a5cac9b9-333a-4b29-bcff-b492ad76fbb7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a603958e-03e4-48cf-b3c3-2b0ed2b0cbca"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a63aff12-b635-46f1-b23c-836b1603f8b8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a667edf5-0a10-46f8-9c06-191a0a7ce30b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a67759ba-103b-4952-883a-0a106819b550"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a7073c71-2f5d-493b-bd81-ac6389ea13e0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a717535b-da52-4406-9304-1f560f928e9a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a94c4f0d-0246-4aef-8786-c675cf71d220"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a9882254-dae6-4c9f-bdc0-7cb68ae3d085"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("a9d56366-03c7-414b-a9df-ffa69aa24811"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("aa544b88-8608-41e2-be8b-5b2e30c5a0c1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("aab97681-632b-4c2a-9da3-631da07b33c6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("abf94f91-edd7-4b72-865a-9ed6c9071baf"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("aca7fa8d-767c-4412-96bd-be35aa8ae05a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ae585b00-ca39-4c57-8912-3d538d874c24"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("aefd7dcb-fea6-4f43-b09d-749a0dbcb104"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("af8859be-ad5f-428d-96a5-9bb3b5fcc935"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("afc5aadb-a043-48f7-a595-8e24eb304d93"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b01b8172-ff95-41b1-9ce0-6678b8839e61"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b02d7c4a-64ea-4e87-b789-a8d4240c76dc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b13999f8-94eb-4258-bc2f-4d9e99e1bdb8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b1d3f625-52c3-455a-904d-dc8a55afc320"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b228461e-a668-4365-b482-ef3de38801e0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b2bded2f-b45e-493c-840b-89c3f9230cf9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b36bddb9-957a-453c-80f2-536274d5746e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b44b07e2-83dd-4c98-8905-9368ba932479"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b48c6830-9c44-47aa-8905-7f967dbf28d1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b522bf8b-5cb0-4767-99a5-77b6e1c75ab4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b8295c3b-3aa4-4d04-a624-7b27ef6fae7c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b90b188c-bc5e-47ab-8f6d-3dbd1fa8a5e9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("b95cfc3f-bb3a-4d75-a7d0-55eaeed6b30e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ba274730-5d3c-4963-b869-48801656f55e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ba61b783-a836-4957-8802-29fcab2dd35c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bb05cfde-c54e-404e-a6ec-ca575bcbe80f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bb2b0fa4-ee6e-4650-a36d-4bc4bea7c8c5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bbbb6643-1f6c-4eb4-87bb-a2c9a591a45d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bc955bd4-cbba-4c35-b063-4ca5c5f46c42"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bd5bc840-4e19-4614-b0f6-158d7da3ea20"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bd68a502-164d-4380-8d90-ba21457b2fba"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bd771dfc-21ce-412e-b81e-071d7818c47f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bdb6254e-d88b-49ea-bf4b-1d05d1dd9ca6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("be522b80-6bb4-4bfb-a7dc-fd2fcda6995c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bf0a3b6b-d48a-4a47-bce5-9335d67f7e63"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bf4687f0-e928-422b-b2d1-d96621b58ca0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("bffa2168-6284-46c1-b364-28cc19a3f464"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c040f632-b68a-4f6d-985d-eade20bdd34a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c0c33498-5559-4652-8e83-74c6a7406bb3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c1473d9f-c07f-4466-9f66-27255feddcc8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c19c0641-a582-4c6b-bfaf-108c8e5fce95"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c1bd813e-7986-41fd-a861-a50b04abe596"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c1fbeafc-663a-4a5a-aa2a-2e24bdcaa753"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c31091d4-6154-433a-9d04-baf92987268a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c4b7d8c1-8066-44f3-940d-f26c9099f793"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c4bc4652-9182-4fce-a3cb-8dadc99848e3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c7084e5e-6358-4663-bb31-c998314bdbf4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c7b06ba7-044b-4961-8130-5f09a3853e5d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c7cd0270-8395-4f57-be4d-156caf841a05"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("c88c12f4-0428-4b7a-8a20-8e303f6bedd7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("cbddb3b5-5fe6-4288-a0cf-addeb300ef52"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("cc6603cd-5780-482d-b444-0f4d92ef0e2e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("cf6dc8e9-f8c5-40e5-b29a-ee02c9dbfa45"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d09feec7-a5e5-4e87-8081-8438c6944aef"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d0d78557-b4c0-4675-bc36-ee6d39fe466f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d1507355-e277-46ae-bbb9-718e634d2305"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d16c8244-d01a-4083-b54b-2479329a3982"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d1854a11-4a09-4d8a-883b-cfaa3ba5ae81"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d3f892ac-01ed-4e70-b044-160c96e969f5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d46a2eef-b40a-4bbd-831b-86fe7b3892f5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d559eaae-c856-4d7e-9449-29c76890aa45"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d5ca0ef0-e42b-48bf-b44b-b3e8684dc80a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d7796a30-fb8b-4574-8fd2-58bc08f63e8c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d830d78e-819d-421d-a172-543f21dd2c76"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d8bc6421-b3bc-45c3-b02a-a7e50c0fbb84"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("d90f7a0a-2448-4154-b368-65409d632de4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("da0cd0d8-7b7a-4b47-b075-157997ae68ff"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("da25231d-bbd4-45bf-9525-9dc546af1748"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("da312297-79e2-4fd8-b3de-2b0365d05a68"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("daaca9c2-c54b-4ba0-a047-169d2ce4f8cc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("db6e177b-4f66-4d42-b49f-afdd14b345d4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("dc4b3ccd-c78b-4ece-9749-b42784d49e73"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("dd7b4ff9-adab-4975-a68c-3ebca6c4de47"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("dda0b761-dc19-4d23-9e14-a6ac71220f39"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ddd00cdc-1993-437b-83f7-0af44ddd6edf"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("df481487-20e3-43a4-be87-ecbf38f7941b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e01635c4-422a-46bb-ae49-17981f0a51d6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e139397c-11b4-441f-b891-a888e7b5a068"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e199c07b-eac9-4f07-90c1-db23c11fc958"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e3968c95-0e40-4ccd-90f3-e2f8f64704bc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e3f2ed2d-b198-4eed-8fb0-b91d636adccd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e510417d-dfa1-417a-83e6-f2ad45f2fe99"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e5b6d2a5-1449-4011-b983-808a24938779"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e758bdc4-dc58-4cca-b95d-4eaf4f619feb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e7e07eab-74af-4297-8b74-7167a7b2c732"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e94b5c16-0ab3-474a-bacd-ed08aa8ca795"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("e96f6ece-7a6f-4e46-8520-efd4a2781ceb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("eba91117-f8c8-4add-a041-3ebd844738d8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ec6e4847-95ae-4e18-8dff-a1c3d7c292a1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ed094942-60b4-43c9-8ae4-c874a3e595f3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ed2231c2-b84f-40bb-a47b-2d8f3121f6f4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ed40bab9-4e5e-48e6-91b3-44af6c6e2716"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ee6030de-3d96-4ee1-b22c-a8706d291eeb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ee6bf6a8-c5e1-41a0-83b1-f4c275857b3f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ee95da7d-7901-4e30-ab19-68445894ed9e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("eebcf1c5-3f7d-438d-b378-39b468ded7dc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ef248f66-b634-4a5d-b451-e59be15ed0ee"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f01eea17-5c1b-4650-8472-71ab442a49ef"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f0cd0c94-670b-42b5-aab1-30927bf3efc3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f17d9ade-2eae-4d94-850d-6880723b86a2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f1e6ee23-7f98-4e0c-bfe2-d2f9be858ae7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f31df194-a7ff-4570-a089-f0482762037c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f3a918ed-3b0d-4a1e-b127-4ab45ee96c0c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f406198e-4c1e-493b-bb9e-3d900f81f27f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f47444ce-6bef-450b-a3d7-481ea419cb2b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f525045f-526a-4cc9-9dd8-907420eb9fc2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f6d4f435-ab2f-49d2-8e67-5ab3344b22a6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f79ea623-c0e9-4afa-9c1b-7a4948a13593"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f7f045f8-8545-4481-8a2f-023a3257da60"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("f835c454-4b9a-4d79-8bbd-73d495568d2c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fa6678e3-0438-4b82-8cf6-2594525e5d2e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fa7a51d3-7012-469b-9c18-f08b51c3968d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("faf25b88-b97f-41e8-9818-882ea1608aaa"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fbbb3e01-bcf3-4162-9e3e-a92cf7de942d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fbcd3a81-fd29-4783-9f63-7476e87b3ad2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fc6a9274-2cb3-4a2d-ac58-05f7a809a8a0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fda1223d-791d-4118-8e5a-8674c05e0d47"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fde54be8-4dcb-4411-b118-08f63445ae81"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fe764af6-e531-4f95-9cff-6a4a3580127a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("fe8bc1c1-685d-4880-a4de-54a5ecdde12a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "customer_info",
                keyColumn: "appointment_request_id",
                keyValue: new Guid("ff9601d7-d166-474d-88d1-2202620dd219"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("002c3edc-11ac-4991-934c-5aee2d05e594"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("00c8fbbb-5d28-42e4-adc7-fa827c91c48e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("012854e6-8d00-4076-b210-34227ec32bbf"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("06abf0c5-fdde-4df2-ad18-4884f53ecf8a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("080eeac4-7c9d-4d28-a026-495fbd367130"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("0aff59bc-77fa-4ad1-bced-21fd96d4e6b3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("0b6daaa0-5b41-4d43-8519-34ed161ea467"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("0d36c4c6-c6da-4299-a1e3-51698bb0a773"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("115c4ec0-be5d-40a3-8afd-d2750d90478e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("11f01456-5075-465b-9278-105066819306"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("13a7a7b0-5c76-42a9-850a-ce9101c533e0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("166596ad-5274-483f-b0d4-3ab1c247361a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("16b7c74b-49a0-4c9e-8c3b-d947a2cbd397"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("170226ca-832e-4ad1-beae-550f4c17a090"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("19637762-6745-4f78-8cc0-bce97471faa3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("1b46df59-865d-40d6-85f6-9c4ff10fd543"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("1c245154-c721-46d2-8c3d-e78a96cea6d9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("1d20adcf-6906-463d-aa47-9e1a0950cb8d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("2076fc6e-7b58-4fdb-b5f3-dcbfc58f1f1a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("21e44831-76f4-480d-afb1-b7824f430432"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("22461b22-8244-4881-9b6a-6a91989db593"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("22754110-8fbb-4000-9dac-85066596690a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("25c7c784-b5c9-4441-9e54-be36cb44dc6c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("28600809-b527-4ba4-9729-5731bf394f20"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("3046060b-c701-4cbe-a4b7-d24915947020"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("30bbb92a-97de-44a6-aed1-6c55b76a990e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("318dd8bb-644b-4eb5-8891-c9d1990f0b1f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("334ce1d9-1d6a-4770-b8c7-ef9aeade786d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("34204d1c-3c92-41fa-961f-8ac0cf9a72f2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("3437000e-218b-488d-9d7b-6e2095a836ab"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("38f91c9b-8a89-4cb1-9255-7f57218ad52b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("394ea754-ba0e-4168-9d57-b59e56c7ad8d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("3be1602c-3fa3-4d40-b5cf-93ff03295602"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("3daeb276-bff5-4427-9133-5ddea26aa68e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("40c42b7f-05ee-4fd3-b68d-9b3114847ac9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("4282ef5c-8e51-4d50-9dc5-6de96cb9dbcc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("4725fb81-6b41-4bd5-8240-557c1f619668"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("4b41f55c-fe8a-415c-b6c4-043c251f1a52"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("503cb288-1336-4c48-a524-e5ea926027e6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("560b623e-b842-4824-a20b-84a69d217711"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("5655cb4e-bc4b-46dd-88b9-a9c69c45699a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("5a5ee1be-c350-47ef-b84d-8cd90ed6ede9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("5ab4fee0-8b93-4071-a8f1-e4807b2fe679"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("5c5cc201-10f0-472d-a5e1-2e15784283af"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("600eb7d2-2e54-4228-b84d-efca6ab6ae6f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("61553f3c-a64c-4fe7-a22e-1ab9b2c4e472"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("61b7115f-fe66-4f59-99bc-8438571b9187"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("628a9add-9c89-4dc2-af9e-fa85c1603346"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("62c8d24f-b224-4598-8d82-e9423d06155a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6891aae4-4f7e-4bf9-8d4d-587667ae7529"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6cf03a8f-84a2-4ecd-8971-f9675dda7eec"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6f633364-7d4a-49f4-9ed4-cad21a0f0445"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("6f71a4d4-fd1a-43b4-a2aa-edb485a18c75"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("70223ac6-94c7-49bb-8cde-304553bba0a7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("711b731c-3215-405d-8e11-16220f26ab2b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("71c1f72e-7dab-465f-8a98-c68e47fbcf64"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("720fe261-8ed8-476a-8d9f-31f5ef5019fd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("7782f8db-aa38-4b9f-b8fe-dc00f63f6711"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("7e483dc1-8bc0-4aec-b396-cb02a0bff7e4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("82ea5dee-b8c1-466a-a725-30a8ddc94cc9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8322e6f0-126c-4010-9675-a229ff54be1e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8365656c-d286-4961-9781-61c707fead52"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("837c25a5-b4d1-4044-904a-197d2577c5e7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("889e068a-cd0c-4202-881a-67ae168510b7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("88b0490a-11f8-4a0a-88bc-d48c924f3d44"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8a75faad-5147-4e60-b36b-382947621837"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8afb2b4e-bc85-4c9b-976b-4695c72d95f3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8c703371-15da-4080-9256-c0c30d32a663"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("8e6bbce4-a58b-4561-a90a-c6227f5dff0d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("91c3f3a6-5be0-4704-8afa-e5cd9747c00c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("91de8ec7-a193-4fb8-b605-354a7a39cf18"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("95fba0bb-a5ca-4ea6-9f59-e176830c05ad"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("96a38731-abfe-42e0-a5be-dfaa5a8c888d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("9b33b5ed-9ad4-4ab7-a49b-d4f7142837a9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("9cb5b3f8-df3e-489c-8eb7-bab1c3c6e605"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("9cbc9e9d-177e-4e47-a3dc-ae75f7a0ba02"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("9cc9240e-4063-4815-a397-b30c95dc2f43"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("9cdad90a-1341-47d1-b7e0-38f4a0ce34c8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("9d9f2cf5-b01e-4e47-ae0e-14d67f4ba34d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a5fe4a91-80ae-41cc-a6ba-57cbbec63947"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a8b7df51-8aaa-4213-898c-4002cc74d5ed"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("a96fa616-9a6e-4c3b-bf64-f3745a234f57"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("ab293326-3449-4f42-b346-98d8a003be33"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("b07bf468-f7b1-4627-8f63-6e169a58d6de"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("b5a651fd-1300-4637-a7e3-90389aff873b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("b5e12ad3-40e3-4c44-96a3-79f55b944c0d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("b7c265b7-f3f9-461b-bcfc-35813ea30240"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("babcabff-ff7a-432b-ab84-68c6063e3c89"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("bc67bf77-ac6f-4908-8548-fabf6305a2ad"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("be743536-089f-41d5-82d7-e9211d4896d0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c127d683-e1f1-44e9-b8d0-2a5fb5b5fcc0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c20f045d-3e19-4b61-9fb9-b5c3931f90e1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c22ac067-a3ab-4941-b45c-ab850f2654c2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c2bc2c73-b94c-4fe4-85a5-81290e01d936"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c448673a-3513-407e-92ec-8df726b1320f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c554b8a3-4387-4d2f-a0bb-65a24f04bb3b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c6194e94-831e-4802-b5cd-4913f896a45e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("c81c2137-2619-4c23-8ef0-5d63b28f7388"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("cca7ee24-96ab-4dca-a4e9-d971210c1fd5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("d14fd8ab-5042-4ade-aea9-d275c9f5f143"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("d931936f-feb8-47f2-b80d-10996223d778"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("dad57ec7-d155-43fb-bff2-7c46d638436e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("db72d7dc-fd95-422e-9261-afad8845326e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("de09311e-1e85-418f-aa0d-d5ae1bb42f3f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("df28c826-2d42-43c4-a11e-3c360d19e86c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e3c9a041-cf1e-4be2-af45-f1739b8eec1b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e49a9435-be60-44a2-9fbb-2897fe33b775"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e6595ace-50a7-45af-9dde-4b178ff67008"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e74b637a-2c70-4e48-b486-bd1e32489de2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e9a5059c-6db2-4bc1-bdba-db739639a083"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("e9e559eb-7e1c-4daf-ac88-b0cea915f4ce"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("eaf637ed-065a-4d45-a436-1f7795eb03de"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("ef045f03-d3cb-4324-9f8d-2ee682f4431a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("ef10e666-291c-49a8-b541-c92dd51dec9f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("f57c536d-65c7-4198-b85f-3f915b0255c1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("f6c2866f-f9cd-434c-a410-bb45d7559f95"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("f7ec0509-f28a-4d7e-8dd1-a183c2fbdb4b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("fd68a21a-ddee-419b-85b0-41a526cc40f7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "operational_hours",
                keyColumn: "id",
                keyValue: new Guid("ff6539b9-8a57-4258-b6b9-3d88eb27ff23"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("000a889f-9ffd-451e-8400-54d3969db426"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("03ce31f1-7ca5-4aec-830b-7795127c6ea4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("03e2c7d3-7386-4368-bbc4-e471254b6780"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("04ce35c7-c4eb-4342-8d6b-f1f0344c2370"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("059402a7-00b0-46c8-9041-33d412389870"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("073c0b66-5a14-43f1-bfaa-4e0a26d5ea8d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("074197db-c049-49ad-be52-3f07506f18df"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("07d787f0-e3ea-4d7b-b16c-8af4e447c65f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("087224d2-7917-4698-ba6a-7e3a8dd0e63b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("09afc615-7181-4e5d-9453-ed0d752d405e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0a444997-c7c2-4670-9d67-e4b3826aa62d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0a8c1911-3d41-4df4-a5a7-b9dc56a427b3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0baa0ab2-df95-497c-a179-95c5a914a627"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0bd2c81d-337d-4698-957b-144f9ed9c694"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0c5566d9-9f23-4e12-9df9-f8b8c7d1b3cd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0c706b02-daa0-4f0e-9d0f-8b2ce17e4bc3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0d6a4701-dde9-4fdb-b96b-865833d46422"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0d7bdb2f-34c0-4619-893d-06a48cd95f73"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0d983d2d-9b6f-49f4-a8e6-250ec962f3f0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0def0d56-139b-4735-b4e1-e81e208263cf"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("0fd5db95-91f3-44ef-a197-ce384f99ee7f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("121a3289-9fb9-4100-9e65-40010cedc888"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("12f01143-f456-46a8-91d5-0ed1c49bbb54"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("14a83535-88ed-4f92-a8a4-b0505e876ab7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("14c70f49-0213-4f62-b1ed-de30aedddbc4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("180f0959-cd56-4dc6-a6b0-8878d6b313df"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1868b44e-f17a-414f-a252-da5f387aaed7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("18ffa0b5-bb47-4651-a999-bd5d35d28bf2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("19bc264b-3cf1-4c57-ae01-c80a525e510f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("19fe168a-0c50-4bc1-b1b7-a6226658f995"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1a816255-847b-478b-b8d3-0e81754e8c84"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1b2b5ed2-c08e-432a-a042-71df0045e35f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1b517727-c4c5-44e5-af23-754f5466bb8d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1b58344b-508f-4ff4-846d-ff22e50781c8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1b58f02f-124a-4c29-94f6-ad46a9012f1f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1b7e092a-e425-4660-b01b-50513e1606fb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1c34c833-bb5f-4045-809e-b0724a8418c9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1c4d6367-a2d8-45dc-8b39-176f24629b2b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1da7f0c2-6bb2-4dc4-9217-1291f1555381"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("1e52fde9-090d-458f-9fe4-4be040784c69"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2059e01d-de89-4a86-850b-ff78b585a4ed"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("21112705-9235-4bfb-8de5-ebaf1ce5acb5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2114b709-1564-445d-a5ca-ca7b217ad380"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("22761405-93ce-4ea1-9dfe-8de6b52829f6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("24739870-6712-465c-bf88-3926c546e780"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("24bead0e-dd0c-40e6-8d6c-830c12125748"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("258108b6-22ba-42b6-a9b4-e5c29ac99d2e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2590391a-97e5-454b-9732-5a52aec76b03"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2594ab6d-6a1d-4d4c-92a7-617e78386970"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("26174ed3-6ea7-464d-aa5d-e22635129b60"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2683e1bd-3777-418f-b045-58fbb1981914"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("26872035-9b0b-4988-b916-8ff0a123bad5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("27ec395c-96dc-40e6-b043-74f51f7837a6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("283567fd-6b2f-42e2-aacf-566f6a691d29"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("289c37b8-9673-4239-8aed-dc0d91411f4d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("28eebef2-4cb1-4e0a-8829-bc6138bc5d41"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("29ba74ca-49e8-4025-8482-d291722d52a4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("29be5e4f-be95-4c5e-a45c-d04fad095c2e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("29dce466-84c6-44bb-8515-0ef518375849"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2a12038b-892a-4ca6-955e-8a04bbcea8c4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2a9134cf-de3a-445a-8c06-fc64224849c1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2b37c7d0-2bcb-41d8-8496-9814251099f3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2d0af977-aaee-42a0-9b86-0217349cc1a0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2e0b6d4f-7216-4346-b993-3a0631c31d88"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2e1c7c1a-033f-41f3-82d7-771c6fb40fab"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2e581802-1b42-472d-bd1f-e5fc38fbd8f9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2ef59a17-db1c-4267-9df8-0634f7d1f3fa"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2f2d3ffd-c8a8-4059-b5cf-14151cd0c58c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("2fee2cf1-1f9f-49e2-96ae-2968b4c2f7db"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("3041e751-ad99-4edf-a50b-1c1f7a75f75b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("316a6687-d301-4104-a313-cc6d3fc63d4c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("31c441df-2bdd-427c-a641-c9485058f311"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("321ff8ae-f663-4117-8ad9-b9f603ad08c8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("34926054-fdb5-4a2d-baef-724201432d17"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("34ade93b-72cb-46fc-b350-1fb7fb3f7b93"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("3542117a-b197-4c55-b3bb-069ac8f5929f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("35775eec-ded1-4c8c-a0e8-c18767a71906"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("368c45ca-7532-4c6f-909a-37166f869c50"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("36bad877-0514-4ba0-a39c-6abc81f6bf2f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("376c4759-3bc5-48fb-8b0e-2d93e30c3247"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("38f03aa0-8f50-4678-8857-8628b1a2c177"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("3af16e01-b93f-4a37-ab79-9b90289f4868"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("3b62e50c-ca45-4789-aaa3-99e173a76217"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("3ca17bed-c61f-4fa9-9754-447d6d104b0e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("3e2fc51b-3fb4-4712-a149-af1c182a9ff8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("40a7426e-f7ad-4f98-acd4-0da99924cedb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("413d27d3-9952-40d9-9ab1-22d7abbce589"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("41a52192-60dc-4364-86f5-c5286a4ff4ee"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("424762c1-2077-43d9-a6f5-ecee63cfee07"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("427a4f97-bdc6-4a7d-a8e7-45c06e107952"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("44a303e1-21b9-465e-bdb0-fa7e934bbaab"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("44f59567-d587-4b7b-9681-88ea188545c2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("44f9e94a-8ef1-429c-8477-5956832c4e15"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4564f744-c107-494b-9585-4e41af673c9a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4639ae6d-774c-4eb7-946e-41e0e61bc5f9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("46e2c2ee-8b06-4db3-a358-5d9486f15766"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("471b2a8d-5abb-4258-b321-297e093af845"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("476d6bdf-1e71-4a7c-9935-26f3d48378d7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("47ee3890-c53d-4908-92e3-ff39dce40130"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("481bbe5f-8a14-4e36-9116-a45464278763"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4947bd1a-20f0-4c27-a70b-6670fbfcb0dd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4a0d02d9-ad3b-4126-aff1-be5b35c6af00"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4bbc8b6a-a7bf-4799-85b0-4313d04c0014"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4c65493c-a6c2-4c7e-b9e4-b947ec2ac68a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4cb409ae-f21f-4837-aa63-900975742f12"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4d4a0cc0-d60f-433b-a55e-b7687b347c40"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4defb677-5c55-43c2-83b3-e374e216fa8b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4e3a13ca-86f3-4b90-ae19-0e82ec7b008d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4ec5f547-6675-41e1-ba3d-a9bb5ee0b3cb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4ec80506-23d4-42b0-a0ec-af612265301c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4f39e1a3-1b2f-4fca-b2b1-a8b2be2b39e2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4f81b3b2-a264-40fe-88e6-659e75cbfa92"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("4fb3921b-a692-4b77-8421-f88ec676c3dd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("50496808-9b93-4661-83eb-d15dfdac7056"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("51d80f6c-2b16-417f-89cf-d912e9cbbdb6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("51e6080c-728d-4e5a-b5df-05417fd43847"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("52486575-4105-438e-b809-c99b4189aaa6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("547ea4b2-dbd0-4ddb-97e9-cf24763bb6da"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("55b7f7f7-1970-43af-ac8f-a53beace83a9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("568f7343-4f09-43bf-9aa8-3a3d5dc51811"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("57222e73-91f2-413c-8dac-a3dc21f4d097"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("57796a87-9011-49a7-b691-7c39dc6861e0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("57f03ef2-0215-4529-83ce-a14f312f443b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("58474d07-052e-4e7e-b9c6-795141c54c07"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5a49b010-7de4-47f4-a011-55a28ade205d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5a9e9d0c-a293-4dd2-8d4f-c83494bb7b26"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5afffb5f-0fa9-4d1d-9aa4-aac82a2fa849"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5b4d54d4-434c-4df8-9011-c0b2f92978ec"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5ba2b145-987b-4649-b2a8-6a38a0896b8b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5c5c5cd6-4274-460a-8b20-8e3c36b5ab96"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5c64ee4a-fc48-4d80-a3a4-a434a6574bac"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5c849c47-22a2-4f2e-93b7-46c8f0940be2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5d03bc1f-709a-403b-8d8c-4915f3377a94"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5d0e6c50-02db-4d7b-9908-e72cc6a2539d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5e60c1ab-c73b-4f61-af6b-0b74ff08f69e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5ec93ebc-2bc0-4a5c-8fc5-5bb8c9a3233f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("5f373d3c-9094-4d6f-8590-a391d722e25c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("60017284-c9d1-4106-ae85-35fd72249c0a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("606a3f7f-9c6f-4761-8704-a5bf8add09e6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("60b769c5-1fc7-468a-829f-0c0b8133beee"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("616c3748-7363-49c5-ba53-7d6e68b073f0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("61aec1bb-dee8-4953-8e50-cdb437ea9c34"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("62be3e89-41a4-4090-9212-ca346d1c9468"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("62e0f79f-314c-42d3-ae7f-f983b73f304e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("632c556b-59d4-446a-adbc-4b054f49f3b6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("633b4e38-adfe-41eb-98d1-8e356251df1e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("635d35c6-d5c7-4429-99bf-d7d7746e8e8e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("656d8e4a-65a0-40a9-85fd-2e2a790d8ca0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("65d01b5f-1831-42b9-a029-389beec88082"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("660d6a9a-470f-488a-8201-b35c46846deb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("670ca4ee-e919-4c4c-84c6-a40627aa168c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("683b23a9-c0b7-4813-a786-0273264cd0e8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("686cd665-4524-469a-bc1c-4bd2d2511227"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("6901707b-ca1e-4f68-8a47-f285b1d2feac"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("6a396a21-f3dd-42b6-b257-e0526be6e702"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("6aea5333-a431-4002-9dcf-8aac5244d7ad"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("6b458b1e-ad06-4bfc-aff4-b1b2dfe3ee29"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("6c948f21-f9d7-40b9-9d10-a04e024b6ea0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("6cb9c018-f36e-4db6-935d-2634e501910c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("6db68e3f-8a5d-4b58-88bd-006adf07e4d7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("6f563eb9-2ff2-41a6-96dd-55fee040a7d6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("6f784dd5-4b16-48ad-947a-08eb981a0d81"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("700e04ad-81bc-4e41-99e1-dcd33d45765a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("71bb0210-7b03-4ccb-90e7-5913ce9c9f9d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("72a3bc0d-82f6-445f-a89e-dc3d31f65f79"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("72b736a8-8408-459f-975e-5965a07374f4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("730d9ec6-b5d6-428e-94dd-aeaec9ef8491"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("73159a53-bf9e-402c-82ca-29196d3aea50"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("73683764-b00f-4c9a-b1ea-07d6cb5b4097"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("73d12bdc-238e-45ec-aa3a-fc24982492a6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("74070cde-7f43-4c2c-805a-bcc445f5b38d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("74e77f21-05b0-4e70-820a-e90a8ec55791"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("760c74d7-62bd-477b-8a84-1720a96d82d9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("765a9b2c-2da5-4d61-b25b-cacc3fa8a63a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("7717b54f-cd1f-4dd5-9004-306ef3891e41"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("773ea1d7-f8bf-4c95-b8d6-1620c878eb78"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("77ec435b-d398-4ab3-a9bd-30993f3dd81c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("786682b1-9f19-45a9-97ee-b1dbaaaecaf1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("78c4cbe5-209a-4536-ba54-c376db3c5d06"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("78dd6168-7df7-4fd7-9786-0c422b745b92"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("78ff43c0-2a33-4ae8-a258-879fa32997fa"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("79fa0585-320a-4ded-9c6c-9ba029bd03ea"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("7cad554e-0d80-46a6-be9c-afdd8882a56c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("7db83cbe-db2c-47fa-823d-f89dd486c83f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("7e1e7d10-10d9-4bc2-ba10-2e5760e1a55d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("7e293435-a128-4557-9d82-89593941b222"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("7e5b7d60-8f5b-4345-adcc-f1cf1c2610ba"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("7f1a3b7f-450e-4269-a5bd-536da316ab05"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("7f396e67-7c29-4cfd-aab5-83ac8c9c9c2f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("7fb5f442-8d48-462c-bc91-19a3ae8f099c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("805d488b-a36c-499e-8148-182beb5d73b1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("8090bfc6-92ba-4551-b66f-bc82125073f7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("80fbdf5f-234d-4fe3-a220-115b5ea5ddcd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("81822ee1-a304-411a-9694-1485333a480e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("81846bce-da8e-4c71-bfb9-c6ab8b6a09c0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("82f00b23-55c3-4fd2-999a-cba36b17bcbc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("83e26c2a-b869-4abe-b0c0-2fef02cd61c6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("865b0916-6a49-4331-862e-4c2d5664b76b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("871c7551-8f69-416b-b91f-449d137de89d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("884e1d46-e865-4733-bd4e-8703aadec435"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("88ace37b-e6b8-4fea-a02b-9fef55fe4c55"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("893c0b41-37e5-4937-bb36-78d9024b4589"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("8a054ddf-b329-486e-8f73-90337ac2d329"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("8c2cece1-aded-4b0d-89c7-baa87a45af68"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("8cd403f2-e844-4c20-91e6-e13480d1167c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("8e435f6e-ed5a-41e3-8840-e8a64a8640c9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("8e4d3fb8-61ca-4b10-93b8-6ff818bb496a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("8f3d2c21-d8c8-4f79-8a8d-85d1cb223e70"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("8fd2b12d-5776-4895-9d3c-40be97c3d807"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("90ee9245-2c58-4e6a-a746-14ada87ed91b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("90fee299-dc67-4a0c-945f-9fac9ab860d4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9140e21a-5187-4379-9dbe-46497d9afe3c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("93069726-28bf-48c0-87fa-8324fc5d226d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("93639d82-96c3-4008-ab51-74b30fe35225"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("94db7c18-e1ed-4317-bf73-ba835df4a61d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("95e801a1-77e5-4d73-8c29-f075302914bb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9614ce83-bcdc-4c03-9962-f1355d534ec6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("96538f02-9ea4-4f99-9263-3ff9c74e2c17"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("967c47e7-2409-496b-ba2b-43e5c3dfe7b3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("96d38851-8d5e-45f1-a0fd-2c776d112e74"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("97006098-9f4b-459c-89ca-a220da7e3474"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("974875a6-b866-4e4a-a9f9-0e35633de0e0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("974c8e0e-c469-4a45-9674-c4c4dacefa6d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("984229df-e3b2-40ac-8638-7133115a9846"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9894d8d1-018c-44c8-88b8-309ffa217a7b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9a4d25fe-2f9a-4c8c-ba2a-ea54bb725322"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9afc79a3-444a-4653-806a-58d0d162d77d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9b1ac5c3-6cd7-4bf2-9743-36646592b9f7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9baa0571-8bd9-42c8-8cb4-f660f84539e2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9c279c68-d3b0-4c69-8d25-139fab7ed87e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9cd507c7-a12c-4c03-b637-e85468e81ecc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9d9e6ffa-ae23-4d74-8e02-9e1b71dcc330"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9e5dff47-748d-435f-94ff-0adf0ea2884c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("9ee07345-8222-4646-83ad-21634f718f7f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a0a88a5e-bbec-4b39-9d79-a2fa74401c42"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a160228a-7649-4a35-b70a-825764be1431"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a25fe8d9-104c-4217-9284-716b9aff1d27"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a292b883-d9dd-4b19-b4ec-df13e68958ee"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a2b0cb2e-f5a4-4b6b-8ff6-a23b931ed563"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a3294d34-3585-4b3c-8fe7-cfbc7a4c573b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a32bf527-64af-4d0e-b2f8-b540d015b08d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a384e267-61fd-4b60-8bda-1d02c24348e1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a4231ae5-829a-4210-8c1f-b454ec5c6dd2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a57f32d2-400b-4d1a-898d-82dfc585dffa"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a5cac9b9-333a-4b29-bcff-b492ad76fbb7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a603958e-03e4-48cf-b3c3-2b0ed2b0cbca"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a63aff12-b635-46f1-b23c-836b1603f8b8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a667edf5-0a10-46f8-9c06-191a0a7ce30b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a67759ba-103b-4952-883a-0a106819b550"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a7073c71-2f5d-493b-bd81-ac6389ea13e0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a717535b-da52-4406-9304-1f560f928e9a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a94c4f0d-0246-4aef-8786-c675cf71d220"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a9882254-dae6-4c9f-bdc0-7cb68ae3d085"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("a9d56366-03c7-414b-a9df-ffa69aa24811"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("aa544b88-8608-41e2-be8b-5b2e30c5a0c1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("aab97681-632b-4c2a-9da3-631da07b33c6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("abf94f91-edd7-4b72-865a-9ed6c9071baf"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("aca7fa8d-767c-4412-96bd-be35aa8ae05a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ae585b00-ca39-4c57-8912-3d538d874c24"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("aefd7dcb-fea6-4f43-b09d-749a0dbcb104"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("af8859be-ad5f-428d-96a5-9bb3b5fcc935"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("afc5aadb-a043-48f7-a595-8e24eb304d93"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b01b8172-ff95-41b1-9ce0-6678b8839e61"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b02d7c4a-64ea-4e87-b789-a8d4240c76dc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b13999f8-94eb-4258-bc2f-4d9e99e1bdb8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b1d3f625-52c3-455a-904d-dc8a55afc320"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b228461e-a668-4365-b482-ef3de38801e0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b2bded2f-b45e-493c-840b-89c3f9230cf9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b36bddb9-957a-453c-80f2-536274d5746e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b44b07e2-83dd-4c98-8905-9368ba932479"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b48c6830-9c44-47aa-8905-7f967dbf28d1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b522bf8b-5cb0-4767-99a5-77b6e1c75ab4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b8295c3b-3aa4-4d04-a624-7b27ef6fae7c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b90b188c-bc5e-47ab-8f6d-3dbd1fa8a5e9"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("b95cfc3f-bb3a-4d75-a7d0-55eaeed6b30e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ba274730-5d3c-4963-b869-48801656f55e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ba61b783-a836-4957-8802-29fcab2dd35c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bb05cfde-c54e-404e-a6ec-ca575bcbe80f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bb2b0fa4-ee6e-4650-a36d-4bc4bea7c8c5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bbbb6643-1f6c-4eb4-87bb-a2c9a591a45d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bc955bd4-cbba-4c35-b063-4ca5c5f46c42"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bd5bc840-4e19-4614-b0f6-158d7da3ea20"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bd68a502-164d-4380-8d90-ba21457b2fba"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bd771dfc-21ce-412e-b81e-071d7818c47f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bdb6254e-d88b-49ea-bf4b-1d05d1dd9ca6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("be522b80-6bb4-4bfb-a7dc-fd2fcda6995c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bf0a3b6b-d48a-4a47-bce5-9335d67f7e63"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bf4687f0-e928-422b-b2d1-d96621b58ca0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("bffa2168-6284-46c1-b364-28cc19a3f464"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c040f632-b68a-4f6d-985d-eade20bdd34a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c0c33498-5559-4652-8e83-74c6a7406bb3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c1473d9f-c07f-4466-9f66-27255feddcc8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c19c0641-a582-4c6b-bfaf-108c8e5fce95"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c1bd813e-7986-41fd-a861-a50b04abe596"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c1fbeafc-663a-4a5a-aa2a-2e24bdcaa753"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c31091d4-6154-433a-9d04-baf92987268a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c4b7d8c1-8066-44f3-940d-f26c9099f793"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c4bc4652-9182-4fce-a3cb-8dadc99848e3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c7084e5e-6358-4663-bb31-c998314bdbf4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c7b06ba7-044b-4961-8130-5f09a3853e5d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c7cd0270-8395-4f57-be4d-156caf841a05"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("c88c12f4-0428-4b7a-8a20-8e303f6bedd7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("cbddb3b5-5fe6-4288-a0cf-addeb300ef52"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("cc6603cd-5780-482d-b444-0f4d92ef0e2e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("cf6dc8e9-f8c5-40e5-b29a-ee02c9dbfa45"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d09feec7-a5e5-4e87-8081-8438c6944aef"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d0d78557-b4c0-4675-bc36-ee6d39fe466f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d1507355-e277-46ae-bbb9-718e634d2305"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d16c8244-d01a-4083-b54b-2479329a3982"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d1854a11-4a09-4d8a-883b-cfaa3ba5ae81"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d3f892ac-01ed-4e70-b044-160c96e969f5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d46a2eef-b40a-4bbd-831b-86fe7b3892f5"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d559eaae-c856-4d7e-9449-29c76890aa45"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d5ca0ef0-e42b-48bf-b44b-b3e8684dc80a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d7796a30-fb8b-4574-8fd2-58bc08f63e8c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d830d78e-819d-421d-a172-543f21dd2c76"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d8bc6421-b3bc-45c3-b02a-a7e50c0fbb84"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("d90f7a0a-2448-4154-b368-65409d632de4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("da0cd0d8-7b7a-4b47-b075-157997ae68ff"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("da25231d-bbd4-45bf-9525-9dc546af1748"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("da312297-79e2-4fd8-b3de-2b0365d05a68"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("daaca9c2-c54b-4ba0-a047-169d2ce4f8cc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("db6e177b-4f66-4d42-b49f-afdd14b345d4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("dc4b3ccd-c78b-4ece-9749-b42784d49e73"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("dd7b4ff9-adab-4975-a68c-3ebca6c4de47"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("dda0b761-dc19-4d23-9e14-a6ac71220f39"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ddd00cdc-1993-437b-83f7-0af44ddd6edf"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("df481487-20e3-43a4-be87-ecbf38f7941b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e01635c4-422a-46bb-ae49-17981f0a51d6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e139397c-11b4-441f-b891-a888e7b5a068"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e199c07b-eac9-4f07-90c1-db23c11fc958"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e3968c95-0e40-4ccd-90f3-e2f8f64704bc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e3f2ed2d-b198-4eed-8fb0-b91d636adccd"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e510417d-dfa1-417a-83e6-f2ad45f2fe99"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e5b6d2a5-1449-4011-b983-808a24938779"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e758bdc4-dc58-4cca-b95d-4eaf4f619feb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e7e07eab-74af-4297-8b74-7167a7b2c732"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e94b5c16-0ab3-474a-bacd-ed08aa8ca795"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("e96f6ece-7a6f-4e46-8520-efd4a2781ceb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("eba91117-f8c8-4add-a041-3ebd844738d8"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ec6e4847-95ae-4e18-8dff-a1c3d7c292a1"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ed094942-60b4-43c9-8ae4-c874a3e595f3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ed2231c2-b84f-40bb-a47b-2d8f3121f6f4"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ed40bab9-4e5e-48e6-91b3-44af6c6e2716"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ee6030de-3d96-4ee1-b22c-a8706d291eeb"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ee6bf6a8-c5e1-41a0-83b1-f4c275857b3f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ee95da7d-7901-4e30-ab19-68445894ed9e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("eebcf1c5-3f7d-438d-b378-39b468ded7dc"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ef248f66-b634-4a5d-b451-e59be15ed0ee"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f01eea17-5c1b-4650-8472-71ab442a49ef"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f0cd0c94-670b-42b5-aab1-30927bf3efc3"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f17d9ade-2eae-4d94-850d-6880723b86a2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f1e6ee23-7f98-4e0c-bfe2-d2f9be858ae7"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f31df194-a7ff-4570-a089-f0482762037c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f3a918ed-3b0d-4a1e-b127-4ab45ee96c0c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f406198e-4c1e-493b-bb9e-3d900f81f27f"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f47444ce-6bef-450b-a3d7-481ea419cb2b"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f525045f-526a-4cc9-9dd8-907420eb9fc2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f6d4f435-ab2f-49d2-8e67-5ab3344b22a6"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f79ea623-c0e9-4afa-9c1b-7a4948a13593"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f7f045f8-8545-4481-8a2f-023a3257da60"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("f835c454-4b9a-4d79-8bbd-73d495568d2c"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fa6678e3-0438-4b82-8cf6-2594525e5d2e"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fa7a51d3-7012-469b-9c18-f08b51c3968d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("faf25b88-b97f-41e8-9818-882ea1608aaa"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fbbb3e01-bcf3-4162-9e3e-a92cf7de942d"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fbcd3a81-fd29-4783-9f63-7476e87b3ad2"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fc6a9274-2cb3-4a2d-ac58-05f7a809a8a0"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fda1223d-791d-4118-8e5a-8674c05e0d47"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fde54be8-4dcb-4411-b118-08f63445ae81"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fe764af6-e531-4f95-9cff-6a4a3580127a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("fe8bc1c1-685d-4880-a4de-54a5ecdde12a"));

            migrationBuilder.DeleteData(
                schema: "appointment_service",
                table: "appointment_request",
                keyColumn: "id",
                keyValue: new Guid("ff9601d7-d166-474d-88d1-2202620dd219"));

            migrationBuilder.DropColumn(
                name: "active",
                schema: "appointment_service",
                table: "appointment_request");

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

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("0d819742-cd02-467c-9116-210baf093806"),
                column: "slot_per_hour",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("1705df44-cbd6-4274-ba29-fb56dad3c6e1"),
                column: "slot_per_hour",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("1a20290c-735d-40f9-a18f-aaa203f19760"),
                column: "slot_per_hour",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("2786bf11-426a-4450-83e3-f0356c929273"),
                column: "slot_per_hour",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("314111ab-e47a-4fb1-a226-15f72a83938a"),
                column: "slot_per_hour",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("412ac93a-41fc-48c5-b25e-b417ac02ae63"),
                column: "slot_per_hour",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("5215f0b1-95b7-445b-b675-cab95abb7132"),
                column: "slot_per_hour",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("957f0253-00e8-4f8d-b713-a7eb2a0acd5a"),
                column: "slot_per_hour",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("c646b3fa-0988-447a-8e41-a967c75ba2f4"),
                column: "slot_per_hour",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("c9878535-5b11-491a-b234-5815cc5f4bfc"),
                column: "slot_per_hour",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("d06615a6-7891-4d5c-a8dc-948f726edec5"),
                column: "slot_per_hour",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("d32218cd-95a2-4094-84be-39eb5b24059a"),
                column: "slot_per_hour",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("dac2973a-3b47-47ca-a265-8f5d15d1f431"),
                column: "slot_per_hour",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("dd1de060-c2e3-42f6-b674-bd0c287564f2"),
                column: "slot_per_hour",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "appointment_service",
                table: "branch",
                keyColumn: "id",
                keyValue: new Guid("ed6978b7-e183-4888-a270-6c5a70cc6038"),
                column: "slot_per_hour",
                value: 6);

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
        }
    }
}

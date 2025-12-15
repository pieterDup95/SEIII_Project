// Persistence/Seed/SeedData.cs
using appointment_service.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace appointment_service.Persistence.Seed
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedBranches(modelBuilder);
            SeedOperationalHours(modelBuilder);
            SeedAppointments(modelBuilder); 
            SeedBranchHolidays(modelBuilder);
        }


        private static void SeedBranches(ModelBuilder modelBuilder)
        {
            var branches = new List<Branch>
                {
                    // Johannesburg & Gauteng
                    new Branch
                    {
                        Id = Guid.Parse("412AC93A-41FC-48C5-B25E-B417AC02AE63"),
                        BranchName = "Sandton City",
                        BranchCode = 630218,
                        Provice = "Gauteng",
                        City = "Johannesburg",
                        Suburb = "Sandton",
                        Address = "Corner Rivonia Road & 5th Street, Sandton City",
                        ContactNumber = "011 783 1234",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 60
                    },
                    new Branch
                    {
                        Id = Guid.Parse("2786BF11-426A-4450-83E3-F0356C929273"),
                        BranchName = "Rosebank Mall",
                        BranchCode = 250601,
                        Provice = "Gauteng",
                        City = "Johannesburg",
                        Suburb = "Rosebank",
                        Address = "50 Bath Avenue, Rosebank",
                        ContactNumber = "011 447 8900",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 60
                    },
                    new Branch
                    {
                        Id = Guid.Parse("57FE6395-7C23-4BE9-8B3D-1005FD926294"),
                        BranchName = "Melrose Arch",
                        BranchCode = 250719,
                        Provice = "Gauteng",
                        City = "Johannesburg",
                        Suburb = "Melrose",
                        Address = "30 Melrose Boulevard, Melrose Arch",
                        ContactNumber = "011 684 1234",
                        AppointmentsPerSlot = 6,
                        SlotDuration = 30
                    },
                    new Branch
                    {
                        Id = Guid.Parse("D06615A6-7891-4D5C-A8DC-948F726EDEC5"),
                        BranchName = "Fourways Mall",
                        BranchCode = 250835,
                        Provice = "Gauteng",
                        City = "Johannesburg",
                        Suburb = "Fourways",
                        Address = "William Nicol Drive & Fourways Boulevard",
                        ContactNumber = "011 465 5678",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 60
                    },

                    // Pretoria
                    new Branch
                    {
                        Id = Guid.Parse("D32218CD-95A2-4094-84BE-39EB5B24059A"),
                        BranchName = "Menlyn Park",
                        BranchCode = 460110,
                        Provice = "Gauteng",
                        City = "Pretoria",
                        Suburb = "Menlyn",
                        Address = "Cnr Atterbury Road & Lois Avenue, Menlyn",
                        ContactNumber = "012 471 1234",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 60
                    },
                    new Branch
                    {
                        Id = Guid.Parse("DAC2973A-3B47-47CA-A265-8F5D15D1F431"),
                        BranchName = "Brooklyn Mall",
                        BranchCode = 460215,
                        Provice = "Gauteng",
                        City = "Pretoria",
                        Suburb = "Brooklyn",
                        Address = "333 Veale Street, Nieuw Muckleneuk",
                        ContactNumber = "012 346 7890",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 30
                    },

                    // Cape Town
                    new Branch
                    {
                        Id = Guid.Parse("314111AB-E47A-4FB1-A226-15F72A83938A"),
                        BranchName = "V&A Waterfront",
                        BranchCode = 050001,
                        Provice = "Western Cape",
                        City = "Cape Town",
                        Suburb = "V&A Waterfront",
                        Address = "Shop 6170, Victoria Wharf, V&A Waterfront",
                        ContactNumber = "021 418 1234",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 30
                    },
                    new Branch
                    {
                        Id = Guid.Parse("C646B3FA-0988-447A-8E41-A967C75BA2F4"),
                        BranchName = "Canal Walk",
                        BranchCode = 050217,
                        Provice = "Western Cape",
                        City = "Cape Town",
                        Suburb = "Century City",
                        Address = "Century Boulevard, Century City",
                        ContactNumber = "021 555 5678",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 60
                    },
                    new Branch
                    {
                        Id = Guid.Parse("DD1DE060-C2E3-42F6-B674-BD0C287564F2"),
                        BranchName = "Claremont",
                        BranchCode = 050102,
                        Provice = "Western Cape",
                        City = "Cape Town",
                        Suburb = "Claremont",
                        Address = "Main Road & Cavendish Street, Claremont",
                        ContactNumber = "021 671 2345",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 60
                    },

                    // Durban & KZN
                    new Branch
                    {
                        Id = Guid.Parse("E003B6CF-613D-4E2C-B1E5-ED3F5E5CE837"),
                        BranchName = "Gateway Theatre of Shopping",
                        BranchCode = 057729,
                        Provice = "KwaZulu-Natal",
                        City = "Durban",
                        Suburb = "Umhlanga",
                        Address = "1 Palm Boulevard, Umhlanga Ridge",
                        ContactNumber = "031 566 8900",
                        AppointmentsPerSlot = 7,
                        SlotDuration = 60
                    },
                    new Branch
                    {
                        Id = Guid.Parse("DC547B0E-FB2A-4CB6-BD25-4C5B5D031E17"),
                        BranchName = "Pavilion Mall",
                        BranchCode = 057801,
                        Provice = "KwaZulu-Natal",
                        City = "Westville",
                        Suburb = "Westville",
                        Address = "Jack Martens Drive, Westville",
                        ContactNumber = "031 275 1234",
                        AppointmentsPerSlot = 6,
                        SlotDuration = 30
                    },
                    new Branch
                    {
                        Id = Guid.Parse("5510587C-CDA4-400B-92DF-00940212C02D"),
                        BranchName = "Musgrave Centre",
                        BranchCode = 057645,
                        Provice = "KwaZulu-Natal",
                        City = "Durban",
                        Suburb = "Berea",
                        Address = "115 Musgrave Road, Berea",
                        ContactNumber = "031 201 5678",
                        AppointmentsPerSlot = 5,
                        SlotDuration = 60
                    },
                     
                    new Branch
                    {
                        Id = Guid.Parse("9A3BFEFA-1E48-452B-A533-CE951FCC1DE3"),
                        BranchName = "Brooklyn Mall",
                        BranchCode = 460215,
                        Provice = "Gauteng",
                        City = "Pretoria",
                        Suburb = "Brooklyn",
                        Address = "333 Veale Street, Brooklyn",
                        ContactNumber = "012 346 7890",
                        AppointmentsPerSlot = 6,
                        SlotDuration = 60
                    },
                    new Branch
                    {
                        Id = Guid.Parse("1A20290C-735D-40F9-A18F-AAA203F19760"),
                        BranchName = "Greenstone Mall",
                        BranchCode = 250945,
                        Provice = "Gauteng",
                        City = "Johannesburg",
                        Suburb = "Edenvale",
                        Address = "Cnr Modderfontein & Van Riebeeck Roads, Greenstone",
                        ContactNumber = "011 452 1234",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 30
                    },
                    new Branch
                    {
                        Id = Guid.Parse("1705DF44-CBD6-4274-BA29-FB56DAD3C6E1"),
                        BranchName = "Tyger Valley",
                        BranchCode = 050419,
                        Provice = "Western Cape",
                        City = "Bellville",
                        Suburb = "Bellville",
                        Address = "Willie van Schoor Avenue, Bellville",
                        ContactNumber = "021 914 5678",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 30
                    },
                    new Branch
                    {
                        Id = Guid.Parse("957F0253-00E8-4F8D-B713-A7EB2A0ACD5A"),
                        BranchName = "Ballito Junction",
                        BranchCode = 057912,
                        Provice = "KwaZulu-Natal",
                        City = "Ballito",
                        Suburb = "Ballito",
                        Address = "Leonora Drive, Ballito",
                        ContactNumber = "032 946 1234",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 60
                    },
                    new Branch
                    {
                        Id = Guid.Parse("5215F0B1-95B7-445B-B675-CAB95ABB7132"),
                        BranchName = "Eastgate Shopping Centre",
                        BranchCode = 250801,
                        Provice = "Gauteng",
                        City = "Johannesburg",
                        Suburb = "Bedfordview",
                        Address = "43 Bradford Road, Bedfordview",
                        ContactNumber = "011 616 5678",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 60
                    },
                    new Branch
                    {
                        Id = Guid.Parse("0D819742-CD02-467C-9116-210BAF093806"),
                        BranchName = "Somerset Mall",
                        BranchCode = 050318,
                        Provice = "Western Cape",
                        City = "Somerset West",
                        Suburb = "Somerset West",
                        Address = "Cnr R44 & N2, Somerset West",
                        ContactNumber = "021 852 1234",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 60
                    },
                    new Branch
                    {
                        Id = Guid.Parse("ED6978B7-E183-4888-A270-6C5A70CC6038"),
                        BranchName = "Cresta Shopping Centre",
                        BranchCode = 250501,
                        Provice = "Gauteng",
                        City = "Johannesburg",
                        Suburb = "Randburg",
                        Address = "Beyers Naudé Drive, Cresta",
                        ContactNumber = "011 478 5678",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 60
                    },
                    new Branch
                    {
                        Id = Guid.Parse("C9878535-5B11-491A-B234-5815CC5F4BFC"),
                        BranchName = "The Pavilion Westville",
                        BranchCode = 057801,
                        Provice = "KwaZulu-Natal",
                        City = "Durban",
                        Suburb = "Westville",
                        Address = "Jack Martens Drive, Dawncliffe",
                        ContactNumber = "031 275 1234",
                        AppointmentsPerSlot = 1,
                        SlotDuration = 30
                    }
                };

            modelBuilder.Entity<Branch>().HasData(branches);
        }

        private static void SeedOperationalHours(ModelBuilder modelBuilder)
        {
            var hours = new List<OperationalHours>();

            // Helper to avoid repeating code
            void AddHours(Guid branchId, DayOfWeek[] days, TimeSpan open, TimeSpan close)
            {
                foreach (var day in days)
                {
                    hours.Add(new OperationalHours
                    {
                        Id = Guid.NewGuid(),
                        BranchId = branchId,
                        DayOfWeek = day,
                        OpenTime = open,
                        CloseTime = close
                    });
                }
            }

            // Extract all branch IDs from list (in order)
            var branchIds = new Dictionary<string, Guid>
            {
                // Johannesburg
                ["Sandton City"] = Guid.Parse("412AC93A-41FC-48C5-B25E-B417AC02AE63"),
                ["Rosebank Mall"] = Guid.Parse("2786BF11-426A-4450-83E3-F0356C929273"),
                ["Melrose Arch"] = Guid.Parse("57FE6395-7C23-4BE9-8B3D-1005FD926294"),
                ["Fourways Mall"] = Guid.Parse("D06615A6-7891-4D5C-A8DC-948F726EDEC5"),
                ["Greenstone Mall"] = Guid.Parse("1A20290C-735D-40F9-A18F-AAA203F19760"),
                ["Eastgate Shopping Centre"] = Guid.Parse("5215F0B1-95B7-445B-B675-CAB95ABB7132"),
                ["Cresta Shopping Centre"] = Guid.Parse("ED6978B7-E183-4888-A270-6C5A70CC6038"),

                // Pretoria
                ["Menlyn Park"] = Guid.Parse("D32218CD-95A2-4094-84BE-39EB5B24059A"),
                ["Brooklyn Mall"] = Guid.Parse("DAC2973A-3B47-47CA-A265-8F5D15D1F431"),
                ["Brooklyn Mall 2"] = Guid.Parse("9A3BFEFA-1E48-452B-A533-CE951FCC1DE3"),

                // Cape Town
                ["V&A Waterfront"] = Guid.Parse("314111AB-E47A-4FB1-A226-15F72A83938A"),
                ["Canal Walk"] = Guid.Parse("C646B3FA-0988-447A-8E41-A967C75BA2F4"),
                ["Claremont"] = Guid.Parse("DD1DE060-C2E3-42F6-B674-BD0C287564F2"),
                ["Tyger Valley"] = Guid.Parse("1705DF44-CBD6-4274-BA29-FB56DAD3C6E1"),
                ["Somerset Mall"] = Guid.Parse("0D819742-CD02-467C-9116-210BAF093806"),

                // Durban an KZN
                ["Gateway Theatre of Shopping"] = Guid.Parse("E003B6CF-613D-4E2C-B1E5-ED3F5E5CE837"),
                ["Pavilion Mall"] = Guid.Parse("DC547B0E-FB2A-4CB6-BD25-4C5B5D031E17"),
                ["Musgrave Centre"] = Guid.Parse("5510587C-CDA4-400B-92DF-00940212C02D"),
                ["Ballito Junction"] = Guid.Parse("957F0253-00E8-4F8D-B713-A7EB2A0ACD5A"),
                ["The Pavilion Westville"] = Guid.Parse("C9878535-5B11-491A-B234-5815CC5F4BFC"),
            };

            var monToFri = new[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday };
            var monToSat = monToFri.Concat(new[] { DayOfWeek.Saturday }).ToArray();
            var monToSun = monToSat.Concat(new[] { DayOfWeek.Sunday }).ToArray();

            // MON–FRI ONLY 
            foreach (var name in new[] { "Sandton City", "Melrose Arch", "Menlyn Park", "Rosebank Mall" })
            {
                AddHours(branchIds[name], monToFri, TimeSpan.Parse("08:00"), TimeSpan.Parse("17:00"));
            }

            // MON–SAT 
            foreach (var name in new[]
            {
                "Fourways Mall", "Brooklyn Mall", "Brooklyn Mall 2", "Canal Walk", "Claremont",
                "Tyger Valley", "Somerset Mall", "Pavilion Mall", "Musgrave Centre",
                "Greenstone Mall", "Eastgate Shopping Centre", "Cresta Shopping Centre", "The Pavilion Westville"
            })
            {
                // Mon–Fri
                AddHours(branchIds[name], monToFri, TimeSpan.Parse("09:00"), TimeSpan.Parse("18:00"));
                // Saturday 
                AddHours(branchIds[name], new[] { DayOfWeek.Saturday }, TimeSpan.Parse("09:00"), TimeSpan.Parse("14:00"));
            }

            // MON–SUN 
            foreach (var name in new[] { "V&A Waterfront", "Gateway Theatre of Shopping", "Ballito Junction" })
            {
                // Mon–Fri
                AddHours(branchIds[name], monToFri, TimeSpan.Parse("09:00"), TimeSpan.Parse("19:00"));
                // Sat & Sun
                AddHours(branchIds[name], new[] { DayOfWeek.Saturday, DayOfWeek.Sunday }, TimeSpan.Parse("09:00"), TimeSpan.Parse("17:00"));
            }

            modelBuilder.Entity<OperationalHours>().HasData(hours);
        }

        private static void SeedAppointments(ModelBuilder modelBuilder)
        {
            var appointments = new List<AppointmentRequest>();
            var customerSeeds = new List<object>();
            var random = new Random(42);

            var firstNames = new[] { "Thabo", "Sipho", "Lerato", "Naledi", "Kagiso", "Anele", "Zinhle", "Tumelo", "Lindiwe", "Bongani" };
            var surnames = new[] { "Mokoena", "Dlamini", "Nkosi", "Van der Merwe", "Smith", "Naidoo", "Pillay", "Govender", "Botha", "Jacobs" };

            var branchIds = new[]
            {
        Guid.Parse("0D819742-CD02-467C-9116-210BAF093806"), 
        Guid.Parse("2786BF11-426A-4450-83E3-F0356C929273"), 
        Guid.Parse("57FE6395-7C23-4BE9-8B3D-1005FD926294"), 
        Guid.Parse("314111AB-E47A-4FB1-A226-15F72A83938A"), 
        Guid.Parse("E003B6CF-613D-4E2C-B1E5-ED3F5E5CE837"), 
        Guid.Parse("D32218CD-95A2-4094-84BE-39EB5B24059A"), 
    };

            var branchOpenDays = new Dictionary<Guid, DayOfWeek[]>
            {
                [Guid.Parse("0D819742-CD02-467C-9116-210BAF093806")] = new[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday },
                [Guid.Parse("2786BF11-426A-4450-83E3-F0356C929273")] = new[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday },
                [Guid.Parse("57FE6395-7C23-4BE9-8B3D-1005FD926294")] = new[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday },
                [Guid.Parse("D32218CD-95A2-4094-84BE-39EB5B24059A")] = new[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday },
                [Guid.Parse("314111AB-E47A-4FB1-A226-15F72A83938A")] = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToArray(),
                [Guid.Parse("E003B6CF-613D-4E2C-B1E5-ED3F5E5CE837")] = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToArray(),
            };

            var startDate = DateTime.Now; // new DateTime(2025, 12, 1);
            var endDate = startDate.AddDays(20);//new DateTime(2025, 12, 2);

            int idCounter = 1;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var dayOfWeek = date.DayOfWeek;

                foreach (var branchId in branchIds)
                {
                    if (!branchOpenDays.TryGetValue(branchId, out var openDays) || !openDays.Contains(dayOfWeek))
                        continue;

                    var (open, close) = branchId == Guid.Parse("0D819742-CD02-467C-9116-210BAF093806")
                        ? (TimeSpan.Parse("08:00"), TimeSpan.Parse("17:00"))
                        : branchOpenDays[branchId].Contains(DayOfWeek.Sunday)
                            ? (TimeSpan.Parse("09:00"), dayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday ? TimeSpan.Parse("17:00") : TimeSpan.Parse("19:00"))
                            : (TimeSpan.Parse("09:00"), dayOfWeek == DayOfWeek.Saturday ? TimeSpan.Parse("14:00") : TimeSpan.Parse("18:00"));

                    var current = open;
                    while (current < close.Add(TimeSpan.FromMinutes(-60)))
                    {
                        if (random.NextDouble() < 0.4)
                        {
                            var id = Guid.NewGuid();
                            var first = firstNames[random.Next(firstNames.Length)];
                            var last = surnames[random.Next(surnames.Length)];
                            var idNumber = $"{random.Next(1970, 2000) % 100:00}{random.Next(1, 13):00}{random.Next(1, 28):00}{random.Next(1000, 9999)}{random.Next(0, 2)}";

                            var appointment = new AppointmentRequest
                            {
                                Id = id,
                                ReferenceNumber = "PB-" + Math.Abs(id.GetHashCode()) % 1_000_000,
                                BranchId = branchId, 
                                Date = DateOnly.FromDateTime(date), 
                                Time = current,
                                Active = true
                            };
                            appointments.Add(appointment);

                            customerSeeds.Add(new
                            {
                                AppointmentRequestId = id,
                                FullName = $"{first} {last}",
                                IdNumber = idNumber.PadRight(13, '0')[..13],
                                ContactNumber = $"0{random.Next(60, 85)}{random.Next(1000000, 9999999)}",
                                Email = $"{first.ToLower()}.{last.ToLower()}@example.com",
                                Notes = random.NextDouble() < 0.3
                                    ? (random.Next(0, 3) switch
                                    {
                                        0 => "Open new account",
                                        1 => "Lost bank card",
                                        _ => "Home loan inquiry"
                                    })
                                    : ""
                            });
                        }
                        current = current.Add(TimeSpan.FromMinutes(60));
                    }
                }
            }

            modelBuilder.Entity<AppointmentRequest>().HasData(appointments);
            modelBuilder.Entity<AppointmentRequest>().OwnsOne(a => a.Customer).HasData(customerSeeds);
        }

        private static void SeedBranchHolidays(ModelBuilder modelBuilder)
        {
            var branchIds = new[]
            {
        Guid.Parse("412AC93A-41FC-48C5-B25E-B417AC02AE63"), 
        Guid.Parse("2786BF11-426A-4450-83E3-F0356C929273"),
        Guid.Parse("57FE6395-7C23-4BE9-8B3D-1005FD926294"),
        Guid.Parse("D06615A6-7891-4D5C-A8DC-948F726EDEC5"),
        Guid.Parse("D32218CD-95A2-4094-84BE-39EB5B24059A"),
        Guid.Parse("DAC2973A-3B47-47CA-A265-8F5D15D1F431"),
        Guid.Parse("314111AB-E47A-4FB1-A226-15F72A83938A"),
        Guid.Parse("C646B3FA-0988-447A-8E41-A967C75BA2F4"),
        Guid.Parse("DD1DE060-C2E3-42F6-B674-BD0C287564F2"),
        Guid.Parse("E003B6CF-613D-4E2C-B1E5-ED3F5E5CE837"),
        Guid.Parse("DC547B0E-FB2A-4CB6-BD25-4C5B5D031E17"),
        Guid.Parse("5510587C-CDA4-400B-92DF-00940212C02D"),
        Guid.Parse("9A3BFEFA-1E48-452B-A533-CE951FCC1DE3"),
        Guid.Parse("1A20290C-735D-40F9-A18F-AAA203F19760"),
        Guid.Parse("1705DF44-CBD6-4274-BA29-FB56DAD3C6E1"),
        Guid.Parse("957F0253-00E8-4F8D-B713-A7EB2A0ACD5A"),
        Guid.Parse("5215F0B1-95B7-445B-B675-CAB95ABB7132"),
        Guid.Parse("0D819742-CD02-467C-9116-210BAF093806"),
        Guid.Parse("ED6978B7-E183-4888-A270-6C5A70CC6038"),
        Guid.Parse("C9878535-5B11-491A-B234-5815CC5F4BFC"),
    };

            var holidays = new[]
            {
        new { Date = new DateOnly(2025, 1, 1),  Name = "New Year's Day" },
        new { Date = new DateOnly(2025, 3, 21), Name = "Human Rights Day" },
        new { Date = new DateOnly(2025, 4, 18), Name = "Good Friday" },
        new { Date = new DateOnly(2025, 4, 21), Name = "Family Day" },
        new { Date = new DateOnly(2025, 4, 27), Name = "Freedom Day" },
        new { Date = new DateOnly(2025, 5, 1),  Name = "Workers' Day" },
        new { Date = new DateOnly(2025, 6, 16), Name = "Youth Day" },
        new { Date = new DateOnly(2025, 8, 9),  Name = "National Women's Day" },
        new { Date = new DateOnly(2025, 9, 24), Name = "Heritage Day" },
        new { Date = new DateOnly(2025, 12, 16), Name = "Day of Reconciliation" },
        new { Date = new DateOnly(2025, 12, 25), Name = "Christmas Day" },
        new { Date = new DateOnly(2025, 12, 26), Name = "Day of Goodwill" },
        new { Date = new DateOnly(2026, 1, 1),  Name = "New Year's Day" },
        new { Date = new DateOnly(2026, 3, 21), Name = "Human Rights Day" },
        new { Date = new DateOnly(2026, 4, 3),  Name = "Good Friday" },
        new { Date = new DateOnly(2026, 4, 6),  Name = "Family Day" },
        new { Date = new DateOnly(2026, 4, 27), Name = "Freedom Day" },
        new { Date = new DateOnly(2026, 5, 1),  Name = "Workers' Day" },
        new { Date = new DateOnly(2026, 6, 16), Name = "Youth Day" },
        new { Date = new DateOnly(2026, 8, 9),  Name = "National Women's Day" },
        new { Date = new DateOnly(2026, 9, 24), Name = "Heritage Day" },
        new { Date = new DateOnly(2026, 12, 16),Name = "Day of Reconciliation" },
        new { Date = new DateOnly(2026, 12, 25),Name = "Christmas Day" },
        new { Date = new DateOnly(2026, 12, 26),Name = "Day of Goodwill" }
    };

            var seedData = new List<BranchHoliday>();

            foreach (var branchId in branchIds)
            {
                foreach (var holiday in holidays)
                {
                    seedData.Add(new BranchHoliday
                    {
                        Id = Guid.NewGuid(),
                        BranchId = branchId,
                        Date = holiday.Date,
                        Description = holiday.Name
                    });
                }
            }

            modelBuilder.Entity<BranchHoliday>().HasData(seedData);
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestHotel.DataAccess.DbConnection;

#nullable disable

namespace TestHotel.DataAccess.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20230523155910_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BookingGuest", b =>
                {
                    b.Property<int>("BookingsBookingId")
                        .HasColumnType("integer");

                    b.Property<int>("GuestsGuestId")
                        .HasColumnType("integer");

                    b.HasKey("BookingsBookingId", "GuestsGuestId");

                    b.HasIndex("GuestsGuestId");

                    b.ToTable("BookingGuest");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Bill", b =>
                {
                    b.Property<int>("InvoiceNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InvoiceNumber"));

                    b.Property<int>("BarCharges")
                        .HasColumnType("integer");

                    b.Property<int>("BookingId")
                        .HasColumnType("integer");

                    b.Property<int>("ChequeNumber")
                        .HasColumnType("integer");

                    b.Property<int>("CreditCardNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("GuestId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("IfLateCheckout")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MiscellaneousCharges")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("RestaurantCharges")
                        .HasColumnType("integer");

                    b.Property<int>("RoomCharge")
                        .HasColumnType("integer");

                    b.Property<int>("RoomService")
                        .HasColumnType("integer");

                    b.Property<int>("paymentMode")
                        .HasColumnType("integer");

                    b.HasKey("InvoiceNumber");

                    b.HasIndex("BookingId");

                    b.HasIndex("GuestId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("BookingTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("GuestId")
                        .HasColumnType("integer");

                    b.Property<int>("HotelId")
                        .HasColumnType("integer");

                    b.Property<int>("NumberAdults")
                        .HasColumnType("integer");

                    b.Property<int>("NumberChildren")
                        .HasColumnType("integer");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("integer");

                    b.Property<int>("RoomNumber1")
                        .HasColumnType("integer");

                    b.HasKey("BookingId");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoomNumber1");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<int>("HotelId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<double>("Salary")
                        .HasColumnType("double precision");

                    b.HasKey("EmployeeId");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GuestId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("BookingId")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<int>("GuestPriority")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("GuestId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("HotelId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StarRating")
                        .HasColumnType("integer");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Room", b =>
                {
                    b.Property<int>("RoomNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoomNumber"));

                    b.Property<int>("HotelId")
                        .HasColumnType("integer");

                    b.Property<string>("Occupancy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("RoomTypes")
                        .HasColumnType("integer");

                    b.HasKey("RoomNumber");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.RoomType", b =>
                {
                    b.Property<int>("RoomTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoomTypeId"));

                    b.Property<string>("RoomImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("integer");

                    b.Property<double>("RoomPrice")
                        .HasColumnType("double precision");

                    b.Property<int>("RoomTypes")
                        .HasColumnType("integer");

                    b.Property<string>("RoomsDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RoomTypeId");

                    b.HasIndex("RoomNumber");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("BookingGuest", b =>
                {
                    b.HasOne("TestHotel.DataAccess.Model.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingsBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestHotel.DataAccess.Model.Guest", null)
                        .WithMany()
                        .HasForeignKey("GuestsGuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Bill", b =>
                {
                    b.HasOne("TestHotel.DataAccess.Model.Booking", "Booking")
                        .WithMany("Bills")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestHotel.DataAccess.Model.Guest", "Guest")
                        .WithMany("Bills")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Booking", b =>
                {
                    b.HasOne("TestHotel.DataAccess.Model.Hotel", "Hotel")
                        .WithMany("Bookings")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestHotel.DataAccess.Model.Room", "Room")
                        .WithMany("bookings")
                        .HasForeignKey("RoomNumber1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Employee", b =>
                {
                    b.HasOne("TestHotel.DataAccess.Model.Hotel", "Hotel")
                        .WithMany("Employees")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestHotel.DataAccess.Model.Role", "Role")
                        .WithMany("Employee")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Room", b =>
                {
                    b.HasOne("TestHotel.DataAccess.Model.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.RoomType", b =>
                {
                    b.HasOne("TestHotel.DataAccess.Model.Room", "Room")
                        .WithMany("roomType")
                        .HasForeignKey("RoomNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Booking", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Guest", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Hotel", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Employees");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Role", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TestHotel.DataAccess.Model.Room", b =>
                {
                    b.Navigation("bookings");

                    b.Navigation("roomType");
                });
#pragma warning restore 612, 618
        }
    }
}

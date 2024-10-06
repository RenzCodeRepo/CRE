﻿// <auto-generated />
using System;
using CRE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRE.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRE.Models.Chairperson", b =>
                {
                    b.Property<int>("chairpersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("chairpersonId"));

                    b.Property<int>("facultyId")
                        .HasColumnType("int");

                    b.HasKey("chairpersonId");

                    b.HasIndex("facultyId")
                        .IsUnique();

                    b.ToTable("Chairperson");
                });

            modelBuilder.Entity("CRE.Models.Chief", b =>
                {
                    b.Property<int>("chiefId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("chiefId"));

                    b.Property<string>("center")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("chiefId");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("Chief");
                });

            modelBuilder.Entity("CRE.Models.CoProponent", b =>
                {
                    b.Property<int>("coProponentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("coProponentId"));

                    b.Property<string>("coProponentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("coProponentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nonFundedResearchId")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("coProponentId");

                    b.HasIndex("nonFundedResearchId");

                    b.ToTable("CoProponent");
                });

            modelBuilder.Entity("CRE.Models.CompletionCertificate", b =>
                {
                    b.Property<int>("completionCertId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("completionCertId"));

                    b.Property<byte[]>("file")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateOnly>("issuedDate")
                        .HasColumnType("date");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urecNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("completionCertId");

                    b.ToTable("CompletionCertificate");
                });

            modelBuilder.Entity("CRE.Models.CompletionReport", b =>
                {
                    b.Property<int>("completionReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("completionReportId"));

                    b.Property<DateOnly>("submissionDate")
                        .HasColumnType("date");

                    b.Property<byte[]>("terminalReport")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("urecNo")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("completionReportId");

                    b.HasIndex("urecNo")
                        .IsUnique()
                        .HasFilter("[urecNo] IS NOT NULL");

                    b.ToTable("CompletionReport");
                });

            modelBuilder.Entity("CRE.Models.EthicsApplication", b =>
                {
                    b.Property<string>("urecNo")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("dtsNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fieldOfStudy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("submissionDate")
                        .HasColumnType("date");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("urecNo");

                    b.HasIndex("userId");

                    b.ToTable("EthicsApplication");
                });

            modelBuilder.Entity("CRE.Models.EthicsApplicationForms", b =>
                {
                    b.Property<int>("ethicsApplicationFormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ethicsApplicationFormId"));

                    b.Property<DateOnly>("dateUploaded")
                        .HasColumnType("date");

                    b.Property<string>("ethicsFormId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte[]>("file")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("urecNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ethicsApplicationFormId");

                    b.HasIndex("ethicsFormId");

                    b.HasIndex("urecNo");

                    b.ToTable("EthicsApplicationForms");
                });

            modelBuilder.Entity("CRE.Models.EthicsApplicationLog", b =>
                {
                    b.Property<int>("logId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("logId"));

                    b.Property<DateTime>("changeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urecNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("logId");

                    b.HasIndex("urecNo");

                    b.HasIndex("userId");

                    b.ToTable("EthicsApplicationLog");
                });

            modelBuilder.Entity("CRE.Models.EthicsClearance", b =>
                {
                    b.Property<int>("ethicsClearanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ethicsClearanceId"));

                    b.Property<DateOnly?>("expirationDate")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<byte[]>("file")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateOnly?>("issuedDate")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("urecNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ethicsClearanceId");

                    b.HasIndex("urecNo")
                        .IsUnique();

                    b.ToTable("EthicsClearance");
                });

            modelBuilder.Entity("CRE.Models.EthicsEvaluation", b =>
                {
                    b.Property<int>("evaluationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("evaluationId"));

                    b.Property<DateOnly?>("endDate")
                        .HasColumnType("date");

                    b.Property<int>("ethicsEvaluatorId")
                        .HasColumnType("int");

                    b.Property<byte[]>("informedConsentForm")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("protocolReviewSheet")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("recommendation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("startDate")
                        .HasColumnType("date");

                    b.Property<string>("urecNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("evaluationId");

                    b.HasIndex("ethicsEvaluatorId");

                    b.HasIndex("urecNo");

                    b.ToTable("EthicsEvaluation");
                });

            modelBuilder.Entity("CRE.Models.EthicsEvaluator", b =>
                {
                    b.Property<int>("ethicsEvaluatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ethicsEvaluatorId"));

                    b.Property<int>("completedEval")
                        .HasColumnType("int");

                    b.Property<int>("declinedAssignment")
                        .HasColumnType("int");

                    b.Property<int>("facultyId")
                        .HasColumnType("int");

                    b.Property<int>("pendingEval")
                        .HasColumnType("int");

                    b.HasKey("ethicsEvaluatorId");

                    b.HasIndex("facultyId")
                        .IsUnique();

                    b.ToTable("EthicsEvaluator");
                });

            modelBuilder.Entity("CRE.Models.EthicsEvaluatorExpertise", b =>
                {
                    b.Property<int>("ethicsEvaluatorId")
                        .HasColumnType("int");

                    b.Property<int>("expertiseId")
                        .HasColumnType("int");

                    b.HasKey("ethicsEvaluatorId", "expertiseId");

                    b.HasIndex("expertiseId");

                    b.ToTable("EthicsEvaluatorExpertise");
                });

            modelBuilder.Entity("CRE.Models.EthicsForm", b =>
                {
                    b.Property<string>("ethicsFormId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte[]>("file")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("formDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("formName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ethicsFormId");

                    b.ToTable("EthicsForm");
                });

            modelBuilder.Entity("CRE.Models.Expertise", b =>
                {
                    b.Property<int>("expertiseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("expertiseId"));

                    b.Property<string>("expertiseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("expertiseId");

                    b.ToTable("Expertise");
                });

            modelBuilder.Entity("CRE.Models.Faculty", b =>
                {
                    b.Property<int>("facultyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("facultyId"));

                    b.Property<int?>("salaryGrade")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<string>("userType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("facultyId");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("CRE.Models.InitialReview", b =>
                {
                    b.Property<int>("initalReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("initalReviewId"));

                    b.Property<int?>("chiefId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("dateReviewed")
                        .HasColumnType("date");

                    b.Property<string>("feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("secretariatId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urecNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("initalReviewId");

                    b.HasIndex("chiefId");

                    b.HasIndex("secretariatId");

                    b.HasIndex("urecNo")
                        .IsUnique();

                    b.ToTable("InitialReview");
                });

            modelBuilder.Entity("CRE.Models.NonFundedResearchInfo", b =>
                {
                    b.Property<string>("nonFundedResearchId")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("campus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("college")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("completionCertId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("completion_Date")
                        .HasColumnType("date");

                    b.Property<DateTime>("dateSubmitted")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ethicsClearanceId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("university")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("urecNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("nonFundedResearchId");

                    b.HasIndex("completionCertId")
                        .IsUnique()
                        .HasFilter("[completionCertId] IS NOT NULL");

                    b.HasIndex("ethicsClearanceId")
                        .IsUnique()
                        .HasFilter("[ethicsClearanceId] IS NOT NULL");

                    b.HasIndex("urecNo")
                        .IsUnique();

                    b.HasIndex("userId");

                    b.ToTable("NonFundedResearchInfo");
                });

            modelBuilder.Entity("CRE.Models.ReceiptInfo", b =>
                {
                    b.Property<string>("receiptNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("amountPaid")
                        .HasColumnType("real");

                    b.Property<DateOnly>("datePaid")
                        .HasColumnType("date");

                    b.Property<byte[]>("scanReceipt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("urecNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("receiptNo");

                    b.HasIndex("urecNo")
                        .IsUnique();

                    b.ToTable("ReceiptInfo");
                });

            modelBuilder.Entity("CRE.Models.Secretariat", b =>
                {
                    b.Property<int>("secretariatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("secretariatId"));

                    b.Property<int>("facultyId")
                        .HasColumnType("int");

                    b.HasKey("secretariatId");

                    b.HasIndex("facultyId")
                        .IsUnique();

                    b.ToTable("Secretariat");
                });

            modelBuilder.Entity("CRE.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("fName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("lName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("mName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CRE.Models.Chairperson", b =>
                {
                    b.HasOne("CRE.Models.Faculty", "Faculty")
                        .WithOne("Chairperson")
                        .HasForeignKey("CRE.Models.Chairperson", "facultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("CRE.Models.Chief", b =>
                {
                    b.HasOne("CRE.Models.User", "User")
                        .WithOne("Chief")
                        .HasForeignKey("CRE.Models.Chief", "userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CRE.Models.CoProponent", b =>
                {
                    b.HasOne("CRE.Models.NonFundedResearchInfo", "NonFundedResearchInfo")
                        .WithMany("CoProponent")
                        .HasForeignKey("nonFundedResearchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NonFundedResearchInfo");
                });

            modelBuilder.Entity("CRE.Models.CompletionReport", b =>
                {
                    b.HasOne("CRE.Models.EthicsApplication", "EthicsApplication")
                        .WithOne("CompletionReport")
                        .HasForeignKey("CRE.Models.CompletionReport", "urecNo");

                    b.Navigation("EthicsApplication");
                });

            modelBuilder.Entity("CRE.Models.EthicsApplication", b =>
                {
                    b.HasOne("CRE.Models.User", "User")
                        .WithMany("EthicsApplication")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CRE.Models.EthicsApplicationForms", b =>
                {
                    b.HasOne("CRE.Models.EthicsForm", "EthicsForm")
                        .WithMany("EthicsApplicationForms")
                        .HasForeignKey("ethicsFormId");

                    b.HasOne("CRE.Models.EthicsApplication", "EthicsApplication")
                        .WithMany("EthicsApplicationForms")
                        .HasForeignKey("urecNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EthicsApplication");

                    b.Navigation("EthicsForm");
                });

            modelBuilder.Entity("CRE.Models.EthicsApplicationLog", b =>
                {
                    b.HasOne("CRE.Models.EthicsApplication", "EthicsApplication")
                        .WithMany("EthicsApplicationLog")
                        .HasForeignKey("urecNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRE.Models.User", "User")
                        .WithMany("EthicsApplicationLog")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("EthicsApplication");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CRE.Models.EthicsClearance", b =>
                {
                    b.HasOne("CRE.Models.EthicsApplication", "EthicsApplication")
                        .WithOne("EthicsClearance")
                        .HasForeignKey("CRE.Models.EthicsClearance", "urecNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EthicsApplication");
                });

            modelBuilder.Entity("CRE.Models.EthicsEvaluation", b =>
                {
                    b.HasOne("CRE.Models.EthicsEvaluator", "EthicsEvaluator")
                        .WithMany("EthicsEvaluation")
                        .HasForeignKey("ethicsEvaluatorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CRE.Models.EthicsApplication", "EthicsApplication")
                        .WithMany("EthicsEvaluation")
                        .HasForeignKey("urecNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EthicsApplication");

                    b.Navigation("EthicsEvaluator");
                });

            modelBuilder.Entity("CRE.Models.EthicsEvaluator", b =>
                {
                    b.HasOne("CRE.Models.Faculty", "Faculty")
                        .WithOne("EthicsEvaluator")
                        .HasForeignKey("CRE.Models.EthicsEvaluator", "facultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("CRE.Models.EthicsEvaluatorExpertise", b =>
                {
                    b.HasOne("CRE.Models.EthicsEvaluator", "EthicsEvaluator")
                        .WithMany("EthicsEvaluatorExpertise")
                        .HasForeignKey("ethicsEvaluatorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CRE.Models.Expertise", "Expertise")
                        .WithMany("EthicsEvaluatorExpertise")
                        .HasForeignKey("expertiseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EthicsEvaluator");

                    b.Navigation("Expertise");
                });

            modelBuilder.Entity("CRE.Models.Faculty", b =>
                {
                    b.HasOne("CRE.Models.User", "User")
                        .WithOne("Faculty")
                        .HasForeignKey("CRE.Models.Faculty", "userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CRE.Models.InitialReview", b =>
                {
                    b.HasOne("CRE.Models.Chief", "Chief")
                        .WithMany("InitialReview")
                        .HasForeignKey("chiefId");

                    b.HasOne("CRE.Models.Secretariat", "Secretariat")
                        .WithMany("InitialReview")
                        .HasForeignKey("secretariatId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRE.Models.EthicsApplication", "EthicsApplication")
                        .WithOne("InitialReview")
                        .HasForeignKey("CRE.Models.InitialReview", "urecNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chief");

                    b.Navigation("EthicsApplication");

                    b.Navigation("Secretariat");
                });

            modelBuilder.Entity("CRE.Models.NonFundedResearchInfo", b =>
                {
                    b.HasOne("CRE.Models.CompletionCertificate", "CompletionCertificate")
                        .WithOne("NonFundedResearchInfo")
                        .HasForeignKey("CRE.Models.NonFundedResearchInfo", "completionCertId");

                    b.HasOne("CRE.Models.EthicsClearance", "EthicsClearance")
                        .WithOne("NonFundedResearchInfo")
                        .HasForeignKey("CRE.Models.NonFundedResearchInfo", "ethicsClearanceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CRE.Models.EthicsApplication", "EthicsApplication")
                        .WithOne("NonFundedResearchInfo")
                        .HasForeignKey("CRE.Models.NonFundedResearchInfo", "urecNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRE.Models.User", "User")
                        .WithMany("NonFundedResearchInfo")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CompletionCertificate");

                    b.Navigation("EthicsApplication");

                    b.Navigation("EthicsClearance");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CRE.Models.ReceiptInfo", b =>
                {
                    b.HasOne("CRE.Models.EthicsApplication", "EthicsApplication")
                        .WithOne("ReceiptInfo")
                        .HasForeignKey("CRE.Models.ReceiptInfo", "urecNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EthicsApplication");
                });

            modelBuilder.Entity("CRE.Models.Secretariat", b =>
                {
                    b.HasOne("CRE.Models.Faculty", "Faculty")
                        .WithOne("Secretariat")
                        .HasForeignKey("CRE.Models.Secretariat", "facultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("CRE.Models.Chief", b =>
                {
                    b.Navigation("InitialReview");
                });

            modelBuilder.Entity("CRE.Models.CompletionCertificate", b =>
                {
                    b.Navigation("NonFundedResearchInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("CRE.Models.EthicsApplication", b =>
                {
                    b.Navigation("CompletionReport")
                        .IsRequired();

                    b.Navigation("EthicsApplicationForms");

                    b.Navigation("EthicsApplicationLog");

                    b.Navigation("EthicsClearance")
                        .IsRequired();

                    b.Navigation("EthicsEvaluation");

                    b.Navigation("InitialReview")
                        .IsRequired();

                    b.Navigation("NonFundedResearchInfo")
                        .IsRequired();

                    b.Navigation("ReceiptInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("CRE.Models.EthicsClearance", b =>
                {
                    b.Navigation("NonFundedResearchInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("CRE.Models.EthicsEvaluator", b =>
                {
                    b.Navigation("EthicsEvaluation");

                    b.Navigation("EthicsEvaluatorExpertise");
                });

            modelBuilder.Entity("CRE.Models.EthicsForm", b =>
                {
                    b.Navigation("EthicsApplicationForms");
                });

            modelBuilder.Entity("CRE.Models.Expertise", b =>
                {
                    b.Navigation("EthicsEvaluatorExpertise");
                });

            modelBuilder.Entity("CRE.Models.Faculty", b =>
                {
                    b.Navigation("Chairperson")
                        .IsRequired();

                    b.Navigation("EthicsEvaluator")
                        .IsRequired();

                    b.Navigation("Secretariat")
                        .IsRequired();
                });

            modelBuilder.Entity("CRE.Models.NonFundedResearchInfo", b =>
                {
                    b.Navigation("CoProponent");
                });

            modelBuilder.Entity("CRE.Models.Secretariat", b =>
                {
                    b.Navigation("InitialReview");
                });

            modelBuilder.Entity("CRE.Models.User", b =>
                {
                    b.Navigation("Chief")
                        .IsRequired();

                    b.Navigation("EthicsApplication");

                    b.Navigation("EthicsApplicationLog");

                    b.Navigation("Faculty")
                        .IsRequired();

                    b.Navigation("NonFundedResearchInfo");
                });
#pragma warning restore 612, 618
        }
    }
}

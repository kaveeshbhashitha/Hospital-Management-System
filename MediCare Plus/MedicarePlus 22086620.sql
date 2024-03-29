USE [master]
GO
/****** Object:  Database [MediCarePlus]    Script Date: 9/16/2023 8:25:28 PM ******/
CREATE DATABASE [MediCarePlus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MediCarePlus', FILENAME = N'D:\Microsoft VS Code\MSSQL16.MSSQLSERVER\MSSQL\DATA\MediCarePlus.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MediCarePlus_log', FILENAME = N'D:\Microsoft VS Code\MSSQL16.MSSQLSERVER\MSSQL\DATA\MediCarePlus_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MediCarePlus] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MediCarePlus].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MediCarePlus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MediCarePlus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MediCarePlus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MediCarePlus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MediCarePlus] SET ARITHABORT OFF 
GO
ALTER DATABASE [MediCarePlus] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MediCarePlus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MediCarePlus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MediCarePlus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MediCarePlus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MediCarePlus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MediCarePlus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MediCarePlus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MediCarePlus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MediCarePlus] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MediCarePlus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MediCarePlus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MediCarePlus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MediCarePlus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MediCarePlus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MediCarePlus] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MediCarePlus] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MediCarePlus] SET RECOVERY FULL 
GO
ALTER DATABASE [MediCarePlus] SET  MULTI_USER 
GO
ALTER DATABASE [MediCarePlus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MediCarePlus] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MediCarePlus] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MediCarePlus] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MediCarePlus] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MediCarePlus] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MediCarePlus', N'ON'
GO
ALTER DATABASE [MediCarePlus] SET QUERY_STORE = ON
GO
ALTER DATABASE [MediCarePlus] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MediCarePlus]
GO
/****** Object:  Table [dbo].[admission]    Script Date: 9/16/2023 8:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admission](
	[admission_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_age] [int] NOT NULL,
	[patient_name] [varchar](150) NOT NULL,
	[patient_mobileno] [varchar](50) NOT NULL,
	[patient_nic] [decimal](18, 0) NOT NULL,
	[doctor_name] [varchar](150) NOT NULL,
	[doctor_specialization] [varchar](150) NOT NULL,
	[admited_date] [date] NOT NULL,
	[room_number] [int] NOT NULL,
	[room_status] [varchar](50) NOT NULL,
	[room_charge_perday] [decimal](18, 2) NOT NULL,
	[guardian_name] [varchar](150) NOT NULL,
	[guardian_nic] [decimal](18, 0) NOT NULL,
	[guardian_mobileno] [varchar](100) NOT NULL,
	[admitting_ID] [varchar](50) NULL,
 CONSTRAINT [PK_admission] PRIMARY KEY CLUSTERED 
(
	[admission_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diagnosis]    Script Date: 9/16/2023 8:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diagnosis](
	[diagnosis_id] [int] IDENTITY(1,1) NOT NULL,
	[treatment_Id] [varchar](50) NOT NULL,
	[patient_age] [int] NOT NULL,
	[patient_name] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[illness] [varchar](50) NOT NULL,
	[note] [varchar](250) NOT NULL,
	[drug_1] [varchar](50) NOT NULL,
	[drug_2] [varchar](50) NOT NULL,
	[drug_3] [varchar](50) NOT NULL,
	[drug_4] [varchar](50) NOT NULL,
	[drug_5] [varchar](50) NOT NULL,
	[drug_6] [varchar](50) NOT NULL,
	[drug_7] [varchar](50) NOT NULL,
	[drug_8] [varchar](50) NOT NULL,
 CONSTRAINT [PK_diagnosis] PRIMARY KEY CLUSTERED 
(
	[diagnosis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctor]    Script Date: 9/16/2023 8:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor](
	[doctor_id] [int] IDENTITY(1,1) NOT NULL,
	[doctor_name] [varchar](150) NOT NULL,
	[doctor_specialization] [varchar](150) NOT NULL,
	[treatment_area] [varchar](150) NOT NULL,
	[doctor_experience] [varchar](50) NULL,
	[doctor_email] [varchar](150) NOT NULL,
	[doctor_nic] [decimal](18, 0) NOT NULL,
	[doctor_mobile] [int] NOT NULL,
	[available_time] [decimal](4, 2) NOT NULL,
	[available_date] [date] NOT NULL,
	[room_number] [int] NOT NULL,
 CONSTRAINT [PK_doctor] PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 9/16/2023 8:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[emaployee_id] [int] IDENTITY(1,1) NOT NULL,
	[employee_name] [varchar](150) NULL,
	[employee_username] [varchar](150) NOT NULL,
	[employee_password] [varchar](150) NOT NULL,
	[empID] [varchar](50) NOT NULL,
	[employee_position] [varchar](50) NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[emaployee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hospitalRoom]    Script Date: 9/16/2023 8:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hospitalRoom](
	[room_id] [int] IDENTITY(1,1) NOT NULL,
	[room_number] [int] NOT NULL,
	[doctor_name] [varchar](150) NOT NULL,
	[doctor_specialization] [varchar](150) NOT NULL,
	[available_date] [date] NOT NULL,
	[available_time] [decimal](4, 2) NOT NULL,
	[availability_status] [varchar](50) NOT NULL,
	[room_charge] [decimal](18, 2) NOT NULL,
	[room_type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_hospitalRoom] PRIMARY KEY CLUSTERED 
(
	[room_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patients]    Script Date: 9/16/2023 8:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[patient_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_firstname] [varchar](150) NOT NULL,
	[patient_lastname] [varchar](150) NOT NULL,
	[patient_mobileno] [varchar](50) NOT NULL,
	[patient_email] [varchar](150) NOT NULL,
	[patient_age] [int] NOT NULL,
	[patient_gender] [varchar](50) NULL,
	[patient_allergy] [varchar](50) NOT NULL,
 CONSTRAINT [PK_patients] PRIMARY KEY CLUSTERED 
(
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payments]    Script Date: 9/16/2023 8:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payments](
	[payment_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_name] [varchar](150) NOT NULL,
	[doctor_name] [varchar](150) NOT NULL,
	[pay_date] [date] NOT NULL,
	[doctor_charge] [decimal](18, 2) NULL,
	[hospital_charge] [decimal](18, 2) NULL,
	[other_charges] [decimal](18, 2) NULL,
	[total_charge] [decimal](18, 2) NOT NULL,
	[service_type] [varchar](50) NULL,
	[pay_ID] [varchar](50) NULL,
 CONSTRAINT [PK_payments] PRIMARY KEY CLUSTERED 
(
	[payment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[schedule]    Script Date: 9/16/2023 8:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[schedule](
	[schedule_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_name] [varchar](150) NOT NULL,
	[patient_age] [int] NOT NULL,
	[patient_gender] [varchar](50) NOT NULL,
	[doctor_name] [varchar](150) NOT NULL,
	[doctor_specialization] [varchar](150) NOT NULL,
	[room_number] [int] NOT NULL,
	[chanel_date] [date] NOT NULL,
	[chanel_time] [decimal](4, 2) NOT NULL,
	[doctor_charge] [decimal](18, 2) NOT NULL,
	[hospital_charge] [decimal](18, 2) NOT NULL,
	[total_charge] [decimal](18, 2) NOT NULL,
	[channel_id] [varchar](50) NULL,
 CONSTRAINT [PK_schedule] PRIMARY KEY CLUSTERED 
(
	[schedule_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[services]    Script Date: 9/16/2023 8:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[services](
	[service_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_age] [int] NOT NULL,
	[patient_name] [varchar](150) NOT NULL,
	[patient_mobileno] [int] NOT NULL,
	[patient_email] [varchar](150) NOT NULL,
	[patient_address] [varchar](150) NOT NULL,
	[room_no] [int] NOT NULL,
	[service_type] [varchar](50) NOT NULL,
	[service_date] [date] NOT NULL,
	[service_time] [decimal](4, 2) NOT NULL,
 CONSTRAINT [PK_services] PRIMARY KEY CLUSTERED 
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [MediCarePlus] SET  READ_WRITE 
GO

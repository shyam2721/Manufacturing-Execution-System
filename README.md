# 🚀 MES Integration with QADT & SAP

## 📌 Project Overview
This project integrates the **QADT system** with a **Manufacturing Execution System (MES)** to automate quality result postings to **SAP**. It provides both **auto** and **manual** posting options through a user-friendly interface.

## 🏗️ Tech Stack
- **Development Environment**: Visual Studio 2022
- **Database**: SQL Server Management Studio
- **Scripting & UI**: Microsoft Excel (for data handling)
- **Backend Technologies**: .NET Framework (C#)

## 🔥 Features
- **Automated Quality Result Posting**: Syncs QADT quality data with SAP.
- **Manual Override Option**: Users can manually post data.
- **User-Friendly Interface**: Designed for seamless interaction.
- **Error Handling & Logs**: Logs every transaction for traceability.

## 📂 Project Structure
```
MES-Integration/
│-- src/                # Source code files
│-- database/           # SQL scripts & configurations
│-- docs/               # Documentation & guides
│-- README.md           # Project documentation
│-- setup-guide.pdf     # Setup & installation guide
```

## 🔧 Installation & Setup
### 1️⃣ Clone the Repository
```sh
git clone https://github.com/shyam2721/MES-Integration.git
cd MES-Integration
```

### 2️⃣ Database Setup
- Import the **SQL scripts** from `database/` into your **SQL Server**.
- Ensure the database connection string is configured correctly in the application.

### 3️⃣ Run the Application
- Open the project in **Visual Studio 2022**.
- Restore dependencies and build the solution.
- Run the project using `F5`.

## 📖 Usage Guide
1. **Login to the MES system**.
2. **Select the QADT dataset** to be posted.
3. **Choose auto/manual posting**.
4. **Review logs** for success or errors.

## 🚀 Deployment Guide
If you want to host this project online, consider:
- **Azure App Service** (Recommended for .NET apps)
- **Heroku** (For API-based hosting)
- **Self-hosting on a Windows Server**

## ❓ Troubleshooting
- **Database Connection Issues**: Check your `app.config` for correct DB credentials.
- **SAP Posting Failures**: Verify SAP API endpoints and credentials.
- **UI Not Loading**: Ensure all required dependencies are installed.
- 
## 📜 License
This project is licensed under the **MIT License**. Feel free to use and modify it!

## ⭐ Show Your Support
If you found this project useful, give it a ⭐ on [GitHub](https://github.com/shyam2721/MES-Integration)! 😊

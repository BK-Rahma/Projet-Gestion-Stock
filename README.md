# Stock Management – WinForms Application (.NET C#)

This project is a desktop application developed in C# (.NET WinForms) that enables product stock management. It is divided into two main parts:
- **Projet** :  the UI and presentation logic layer.  
- **Projet.Data** : the data access and business logic layer.

---

## 📸 Application Preview

![image](https://github.com/user-attachments/assets/99b56d2e-5209-4e25-ab0f-6d663955c91c)
![image](https://github.com/user-attachments/assets/a7810c02-21ed-4c4d-ac56-7fe5b11778bf)
![image](https://github.com/user-attachments/assets/5c57d4e8-2c3d-4d33-bc4b-fe92c4958895)
![image](https://github.com/user-attachments/assets/49a83612-d4ff-4abc-a122-e8872abfbf21)
![image](https://github.com/user-attachments/assets/cfc5b98a-26ab-4c5d-8a48-3dc06c6b947c)

---

## 📁 Project Structure

Solution 'Projet'

├── Projet

│ ├── AddAdminCategories.cs

│ ├── AddAdminProduct.cs

│ ├── LoginForm.cs

│ ├── MainForm.cs (Designer + Ressources)

│ ├── RegisterForm.cs

│ ├── Program.cs

│ ├── stock.db (SQLite Database)

│ └── Assets / Resources / Properties / Dépendances

│

├── Projet.Data

│ ├── Entities

│ │ ├── Categorie.cs

│ │ ├── Produit.cs

│ │ └── Utilisateur.cs

│ │

│ ├── Repositories

│ │ ├── CategorieRepository.cs

│ │ ├── ProduitRepository.cs

│ │ └── UtilisateurRepository.cs

│ │

│ ├── Migrations

│ │ ├── 20250508143302_InitialCreate.cs

│ │ └── AppDbContextModelSnapshot.cs

│ │

│ └── AppDbContext.cs


---

## 🛠 Main Features

✅ User authentication (Login / Register)
✅ Category management: add, update, delete
✅ Product management: add, update, delete
✅ Embedded database (SQLite)
✅ Layered architecture (UI / Data / Repositories)

---

## 🏗 Technologies Used

- **C# (.NET WinForms)**  
- **Entity Framework Core** (Code First + Migrations)  
- **SQLite**  for the database
- **Repository Pattern**  for data access

---
## 👥 Contributors
- **Rahma Bochnak**
- **Siwar Chiha**
---
## 🚀 Run the Application

1️⃣ Open the solution with Visual Studio
2️⃣ Make sure NuGet packages are restored:
```bash
dotnet restore

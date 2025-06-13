# Gestion du Stock – Application WinForms (.NET C#)

Ce projet est une application desktop développée en **C# (.NET WinForms)** qui permet la gestion d’un stock de produits. Elle est divisée en deux parties principales :  
- **Projet** : la couche interface et logique de présentation.  
- **Projet.Data** : la couche accès aux données et logique métier.

---

## 📸 Aperçu de l'application

![image](https://github.com/user-attachments/assets/99b56d2e-5209-4e25-ab0f-6d663955c91c)
![image](https://github.com/user-attachments/assets/a7810c02-21ed-4c4d-ac56-7fe5b11778bf)
![image](https://github.com/user-attachments/assets/5c57d4e8-2c3d-4d33-bc4b-fe92c4958895)
![image](https://github.com/user-attachments/assets/49a83612-d4ff-4abc-a122-e8872abfbf21)
![image](https://github.com/user-attachments/assets/cfc5b98a-26ab-4c5d-8a48-3dc06c6b947c)

---

## 📁 Structure du projet

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

## 🛠 Fonctionnalités principales

✅ Authentification des utilisateurs (Login / Register)  
✅ Gestion des catégories : ajout, modification, suppression  
✅ Gestion des produits : ajout, modification, suppression  
✅ Base de données intégrée (SQLite)  
✅ Séparation en couches (interface / données / repositories)

---

## 🏗 Technologies utilisées

- **C# (.NET WinForms)**  
- **Entity Framework Core** (Code First + Migrations)  
- **SQLite** pour la base de données  
- **Repository Pattern** pour l’accès aux données  

---
## 👥 Contributors
- **Rahma Bochnak**
- **Siwar Chiha**
---
## 🚀 Lancer l'application

1️⃣ Ouvre la solution avec **Visual Studio**  
2️⃣ Assure-toi d’avoir les packages NuGet restaurés :  
```bash
dotnet restore

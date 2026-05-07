# .NET Pizza API & Sales Summary Application

## 📖 Overview

This project is a C#/.NET 8 application that demonstrates core concepts of building modern applications using ASP.NET Core and file handling.

It consists of two main parts:

1. A **Pizza Web API** that supports full CRUD operations
2. A **Sales Summary Console Feature** that processes text files and generates a report

The project was developed as part of a Microsoft Learn module on building .NET applications.

---

## 🍕 Part 1: Pizza Web API

The Pizza API is a RESTful service built with ASP.NET Core that allows users to manage pizza data.

### ✨ Features

* Retrieve all pizzas (GET)
* Retrieve a pizza by ID (GET)
* Add a new pizza (POST)
* Update an existing pizza (PUT)
* Delete a pizza (DELETE)
* Includes an additional custom pizza record

### 📌 Example Data

```json
{
  "id": 4,
  "name": "Vegetarian Supreme",
  "isGlutenFree": true
}
```

### 🔗 API Endpoints

| Method | Endpoint        | Description      | Status Code                    |
| ------ | --------------- | ---------------- | ------------------------------ |
| GET    | /api/pizza      | Get all pizzas   | 200 OK                         |
| GET    | /api/pizza/{id} | Get pizza by ID  | 200 OK / 404 Not Found         |
| POST   | /api/pizza      | Create new pizza | 201 Created                    |
| PUT    | /api/pizza/{id} | Update pizza     | 204 No Content / 404 Not Found |
| DELETE | /api/pizza/{id} | Delete pizza     | 204 No Content / 404 Not Found |

---

## 📊 Part 2: Sales Summary Generator

This feature reads sales data from multiple `.txt` files and generates a summary report.

### ✨ Features

* Reads all `.txt` files from a folder
* Calculates total sales per file
* Calculates overall total sales
* Generates a formatted report
* Saves report to a file (`SalesSummaryReport.txt`)

### 📄 Sample Output

```text
Sales Summary
----------------------------
Total Sales: $10,500.00

Details:
  sales1.txt: $3,500.00
  sales2.txt: $7,000.00
```

---

## 🛠️ Technologies Used

* C#
* .NET 8 (LTS)
* ASP.NET Core Web API
* File I/O (System.IO)
* StringBuilder (System.Text)

---

## 🚀 How to Run the Project

### 1. Clone the Repository

```bash
[git clone https://github.com/mrchigozieike/PizzaApi.git
```

### 2. Navigate to the Project

```bash
cd your-repo-name
```

### 3. Run the API

```bash
dotnet run
```

### 4. Test API Endpoints

Use tools like:

* Postman
* curl
* Browser (GET only)

---

## 📁 Project Structure

```plaintext
/ProjectRoot
 ├── Controllers/
 │    └── PizzaController.cs
 ├── Models/
 │    ├── Pizza.cs
 │    └── PizzaStore.cs
 ├── Program.cs
 ├── SalesData/
 ├── SalesSummaryReport.txt
 ├── README.md
 └── notes.md
```

---

## 🧪 Testing Evidence

### ✔ GET

Returns list of pizzas → **200 OK**

### ✔ POST

Creates new pizza → **201 Created**

### ✔ PUT

Updates pizza → **204 No Content**

### ✔ DELETE

Deletes pizza → **204 No Content**

---

## 🧠 Learning Outcomes

* Understanding RESTful API design
* Implementing CRUD operations in ASP.NET Core
* Working with in-memory data storage
* Reading and processing files in C#
* Generating reports using StringBuilder
* Using HTTP status codes correctly

---

## 👤 Author

**Chigozie Henry Ike**

* GitHub: https://github.com/mrchigozieike/PizzaApi.git

---

## 📄 Notes

This project was completed as part of a Microsoft Learn assignment.
It demonstrates both API development and file processing in .NET.

---

## 📌 Future Improvements

* Connect API to a real database (SQL Server/PostgreSQL)
* Add validation and error handling
* Implement authentication
* Improve UI with a frontend client

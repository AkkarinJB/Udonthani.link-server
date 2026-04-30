# Udonthani.link - Backend API

ระบบจัดการฐานข้อมูลและให้บริการ API (Web API) สำหรับแพลตฟอร์มหางานจังหวัดอุดรธานี (Udonthani.link) 
โปรเจกต์นี้ใช้สถาปัตยกรรมการพัฒนาแบบ **Code-First** และจัดโครงสร้างโฟลเดอร์แบบแบ่งสัดส่วนหน้าที่ (Separation of Concerns)

## Tech Stack
* **Framework:** ASP.NET Core Web API (.NET 8)
* **Language:** C#
* **Database:** MySQL / MariaDB (รันผ่าน XAMPP)
* **ORM:** Entity Framework Core
* **API Documentation:** Swagger

---

## โครงสร้างโปรเจกต์

โปรเจกต์ถูกแบ่งออกเป็นหมวดหมู่เพื่อให้ง่ายต่อการพัฒนาและดูแลรักษา:

* `Controllers/` : HTTP Request/Response
* `Models/` : Entities คลาสที่เป็นตัวแทนของตารางในฐานข้อมูล MySQL
* `Data/` : เก็บไฟล์ `AppDbContext.cs` สำหรับตั้งค่าการเชื่อมต่อฐานข้อมูล และเก็บไฟล์ Migrations
* `DTOs/` :  คลาสสำหรับกำหนดรูปร่างข้อมูลเฉพาะส่วนที่ใช้รับ-ส่ง
* `Services/` : *[กำลังพัฒนา]* สำหรับเก็บ Business Logic และการคำนวณต่างๆ
* `Helpers/` : *[กำลังพัฒนา]* สำหรับเก็บโค้ดที่ใช้ซ้ำๆ

---

## สิ่งที่ต้องติดตั้ง

1. **[.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)**
2. **MySQL Server** (แนะนำให้เปิดผ่าน [XAMPP](https://www.apachefriends.org/) หรือโปรแกรมจำลอง Server อื่นๆ)
3. **IDE:** Visual Studio Code (แนะนำให้ติดตั้ง Extension: `C# Dev Kit`) หรือ Visual Studio 2022
4. **Git**
5. **EF Core Tools:** เครื่องมือจัดการฐานข้อมูล (ติดตั้งโดยเปิด Terminal พิมพ์: `dotnet tool install --global dotnet-ef`)

---

## ขั้นตอนการตั้งค่าและรันโปรเจกต์ 

### 1. โคลนโปรเจกต์ลงเครื่อง
เปิด Terminal แล้วพิมพ์คำสั่งเพื่อ clone โปรเจคลงเครื่องตัวเอง
```bash
git clone https://github.com/AkkarinJB/Udonthani.link-server.git
```

```bash
cd Udonthani.link-server
```

```bash
git branch feature/ชื่อตัวเอง
```

```bash
git checkout feature/ชื่อตัวเอง ที่สร้างเมื่อขั้นตอนที่เเล้ว
```

### 2. เดี๋ยวมาเขียนต่อครับ 55555 


# UC Reviews

UC Reviews is a full-stack web application built as a **senior year capstone project** at the University of Cincinnati.  
The app allows UC students to leave detailed reviews about **professors, dorms, dining halls, and parking garages**.  
Unlike traditional feedback kiosks, UC Reviews captures **contextual, actionable insights** through text reviews, star ratings, likes/dislikes, pagination, and reporting tools.  

The project was showcased at the **University of Cincinnati IT Expo (2025)**, where it received **100% in the technical evaluation**, under the supervision of **Professor Dyllon Dekok**.  

⚡ Note: This is a **forked repository**. The original source can be found here:  
🔗 [Elliott03/UCReviews](https://github.com/Elliott03/UCReviews)

## ✨ Features

- **Authentication** – Login via Google, Apple, or UC credentials  
- **Entity Listings** – Professors, Dorms, Dining Halls, Parking Garages  
- **Individual Pages** – Each entity has its own detail page with reviews  
- **Review System** – Add textual reviews, star ratings, likes/dislikes  
- **Reporting Tools** – Flag inappropriate or irrelevant content  
- **Anonymous Posting** – Option to contribute privately  
- **Admin Dashboard** – Manage reported reviews, track analytics, moderate content  
- **Pagination** – Smooth navigation for large review datasets  
- **Responsive Design** – Accessible on desktop and mobile browsers  
- **Data Security** – Secure login, salted hashing, parameterized queries, minimal attack surface  

## 📸 UI Mockups


> Home / Login  
  ![Home](./web-client/home.webp)

> Professors  
  ![Professors](./web-client/professors.webp)

- Parking Garages
  ![Garages](./web-client/garages.webp)

- Dorms  
  ![Dorms](./web-client/dorms.webp)

- Admin Dashboard / Backpanel  
  ![Admin](./web-client/admin.webp)


## 🏗️ Technical Architecture

This application consists of **three components**:  

1. **Backend** – A RESTful API built using **C#** and **Entity Framework**  
2. **Frontend** – Built in **Angular**  
3. **Database** – Powered by **Microsoft SQL Server**  

The backend interacts with the database and handles requests from the frontend. It consists of:  

- **Controllers** – Each entity has a dedicated controller that handles HTTP requests and delegates logic to services.  
- **Services** – Contain application logic and serve as intermediaries between controllers and repositories.  
- **Repositories** – Abstract database operations, ensuring clean data access.  

> 📊 Diagram
![Technical Architecture](./diagram-1.png)


## 👥 User Personas

UC Reviews was designed around common UC community roles:  

- **Student Persona** – Wants to find reliable information about dorms, dining halls, professors, and parking.  
- **Faculty Persona** – Reviews professor feedback to improve teaching quality.  
- **Administrator Persona** – Uses the admin dashboard to moderate flagged reviews and track trends.  

> 📊 Diagram
![User Personas](./user-persona.png)


## 📊 Use Case Diagram

The system supports multiple interactions:  

- **Students** – Login, browse listings, submit reviews, upvote/downvote reviews, report inappropriate content.  
- **Admins** – Moderate flagged content, view analytics dashboard, manage users if necessary.  

> 📊 Diagram
![Use Case Diagram](./usecase.png)

---

## 📑 Financial Report

Full final analysis of the project is available in the report below:  

📄 [Final Report (PDF)](./Financial_Report.pdf)


## 🚀 Getting Started

### Prerequisites
- Node.js + Angular CLI
- .NET SDK
- Microsoft SQL Server

### Development Server
```bash
cd WebClient
ng serve
```
Navigate to http://localhost:4200/. The app will auto-reload on changes.

### Build
```bash
ng build
```
Build artifacts are stored in the dist/ directory.

### Unit Tests
```bash
ng test
```

### End-to-End Tests
```bash
ng e2e
```

## 🎯 Project Goals
- Provide comprehensive student feedback across UC campus life  
- Improve student experience through data-driven insights  
- Ensure privacy and safety with anonymous and moderated reviews  
- Deliver a responsive and intuitive interface  


## 👩‍💻 Contributors
- Adam Tulloss  
- Elliott Phillips  
- Chase Staggs  
- Pratik Chaudhari  


## 🔮 Future Enhancements
- Analytics dashboard for trends in reviews  
- Machine learning–based sentiment analysis of reviews  


## 🏆 Recognition
- Presented at the University of Cincinnati IT Expo 2025  
- Awarded 100% technical evaluation score  
- Project completed under the supervision of Professor Dyllon Dekok  

## 📜 License
© 2025 Adam Tulloss, Chase Staggs, Pratik Chaudhari, Elliott Phillips  
This project was developed for academic purposes at the **University of Cincinnati**.  
Please refer to the [original repository](https://github.com/Elliott03/UCReviews) for licensing details.


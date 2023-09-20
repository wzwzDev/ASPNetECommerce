# Virtual Store Project

This is a virtual store project developed using ASP.NET MVC and WebAPI. It allows users to browse, select, and purchase products from a catalog.
## 

1. **Database Tables:** The project includes various database tables to store product information, user data, and order details.

2. **Entity Framework:** Entity Framework is used for data access and database interactions.

3. **Sessions with ModelBinder:** The application uses session management, particularly for the shopping cart, and leverages ModelBinders to handle cart interactions.

4. **Product Listings:** Users can view a list of available products in the catalog.

5. **Add to Cart:** Users can add one or more products to their shopping cart.

6. **View Cart:** Users can view the contents of their shopping cart, see the products they have added, and modify quantities.

7. **Order Checkout:** Users can complete their order, which involves moving cart items to an order table, reducing product stock, and calculating the total cost of the order.

8. **Stock Management:** When an order is placed, the project automatically decreases the stock quantity of the purchased products. If a product's stock reaches zero, it is either not displayed or marked as "out of stock" with appropriate visual indicators.

### 

1. **Product Images:** Product images are displayed alongside product listings.

2. **Product Management (Admin):** An admin panel allows for the creation, editing, and deletion of products.

3. **Foreign Keys and Relationships:** The database includes foreign keys and relationships between tables for data integrity.

4. **User Authentication:** Users can log in with their credentials, and their identity is used for order tracking.

5. **CSS Styling:** The project features CSS styles for an appealing user interface.

6. **Master Pages (Layout):** Layout templates provide a consistent look and feel across the application.

7. **RESTful API:** An API endpoint is available to fetch a list of products.

8. **Input Validation:** User input is validated to prevent errors and security vulnerabilities.

9. **Low Stock Alert:** If a product's stock falls below a certain threshold (e.g., 2 units), a record is created in a stock table to prompt restocking.

10. **Total Order Amount:** The project calculates and stores the total order amount.

## Getting Started

To run this project locally, follow these steps:

1. Clone the repository to your local machine.

2. Open the project in Visual Studio.

3. Set up the database and update the connection string in the `web.config` file.

4. Build and run the application.

5. Explore the virtual store and test its various features.

## Contributors

- [Wael Louati] - [waelwzwz@gmail.com]


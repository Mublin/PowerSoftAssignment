# Powersoft-solutions
### Project Description: Cryptocurrency API

#### Overview

The Cryptocurrency API is an ASP.NET Core Web API designed to interact with the CoinCap API to provide detailed information about various cryptocurrencies. The API allows users to retrieve a list of all available cryptocurrencies, as well as search, sort, and paginate through the results. It also provides detailed information about specific cryptocurrencies by their ID.

#### Features

1. **List All Cryptocurrencies**
   - Endpoint: `/api/crypto`
   - Description: Retrieves a list of all available cryptocurrencies.
   - Supports sorting by various parameters such as name, price, and market cap.
   - Supports pagination to manage large sets of data.

2. **Get Cryptocurrency by ID**
   - Endpoint: `/api/crypto/{id}`
   - Description: Retrieves detailed information about a specific cryptocurrency by its ID.

3. **Sorting**
   - Description: Allows sorting of cryptocurrency data by name, price, market cap, and rank.

4. **Pagination**
   - Description: Allows paginated access to the list of cryptocurrencies, providing a manageable way to browse through large datasets.

#### Technologies Used

- **.NET 8**
  - Utilizes the latest features and improvements in .NET 8.
- **ASP.NET Core**
  - Leverages the flexibility and performance of ASP.NET Core for building web APIs.
- **HttpClient**
  - Used for making HTTP requests to the CoinCap API.
- **Newtonsoft.Json**
  - Used for JSON serialization and deserialization to handle responses from the CoinCap API.

#### Project Structure

- **Controllers**
  - `CryptoController`: Handles API requests for listing and retrieving cryptocurrency data.
- **Services**
  - `CryptoService`: Contains business logic for interacting with the CoinCap API, sorting, and pagination.
- **Models**
  - `CryptoCurrency`: Represents the data model for a cryptocurrency.
- **Endpoint**
  - `CryptoEndpoint`: Defines the routes and maps them to the appropriate methods in the service layer.

#### Setup and Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-repo/crypto-api.git
   cd crypto-api
   ```

2. **Build and Run the Project**
   ```bash
   dotnet build
   dotnet run
   ```

3. **Access the API**
   - The API will be available at `http://localhost:5000/api/crypto`.

#### API Endpoints

1. **GET /api/crypto**
   - Description: Retrieves a list of all cryptocurrencies.
   - Query Parameters:
     - `sortBy` (optional): Field to sort by (`name`, `price`, `marketcap`, `rank`).
     - `page` (optional): Page number (default is 1).
     - `pageSize` (optional): Number of items per page (default is 10).

2. **GET /api/crypto/{id}**
   - Description: Retrieves details of a specific cryptocurrency by ID.

#### Example Usage

- **List all cryptocurrencies (sorted by name, page 1, 10 items per page)**
  ```
  GET http://localhost:5000/api/crypto?sortBy=name&page=1&pageSize=10
  ```

- **Get details of a specific cryptocurrency by ID**
  ```
  GET http://localhost:5000/api/crypto/bitcoin
  ```

#### Error Handling

The API includes basic error handling to manage scenarios such as invalid IDs and unexpected issues with the CoinCap API. These errors are returned with appropriate HTTP status codes and messages to help clients understand what went wrong.

#### Future Enhancements

- **Filtering**: Add support for filtering cryptocurrencies based on various criteria such as market cap range, price range, etc.
- **Caching**: Implement caching to reduce the load on the CoinCap API and improve response times.
- **Authentication**: Add authentication and authorization mechanisms to secure the API.

---

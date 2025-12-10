// src/App.tsx
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "./components/Header";
import Footer from "./components/Footer";
import Home from "./pages/Home";
import BookAppointment from "./pages/BookAppointment";
import Products from "./pages/Products";
import ProductDetail from "./pages/ProductDetail";
import About from "./pages/About";
import ScrollToTop from "./ScrollToTop";

// Global styles & smooth scrolling
import "./index.css"; // Make sure you have this file

export default function App() {
  return (
    <Router>
      {/* Smooth scrolling & modern font rendering */}
      <div className="flex flex-col min-h-screen bg-white antialiased">
        <Header />

        <main className="flex-1">
          <ScrollToTop />
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/book" element={<BookAppointment />} />
            <Route path="/products" element={<Products />} />
            <Route path="/products/:productId" element={<ProductDetail />} />
            <Route path="/about" element={<About />} />

            {/* Optional: 404 page later */}
            {/* <Route path="*" element={<NotFound />} /> */}
          </Routes>
        </main>

        <Footer />
      </div>
    </Router>
  );
}
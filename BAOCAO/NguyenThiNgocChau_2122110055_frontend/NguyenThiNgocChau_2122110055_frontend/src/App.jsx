import { useState } from 'react'
import { BrowserRouter as Router, Routes, Route, useLocation } from 'react-router-dom'
import Header from './components/Header'
import Banner from './components/Banner'
import Home from './components/Home'
import ProductDetail from './components/ProductDetail'
import Footer from './components/Footer'
import Cart from './components/Cart'
import Login from './components/Login'
import ProductList from './components/ProductList'
import Admin from './components/Admin'

import { useEffect } from 'react'
import AdminProductList from './components/AdminProductList'
import AdminBrandList from './components/AdminBrandList'

function Layout() {
  const location = useLocation();
  const isAdminPage = location.pathname.startsWith('/admin');

  return (
    <div className='bg-black pb-10 min-h-screen'>
      {/* Chỉ hiển thị header/banner/footer nếu không phải trang admin */}
      {!isAdminPage && <Header />}
      {!isAdminPage && <Banner />}

      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/product/:id" element={<ProductDetail />} />
        <Route path="/cart" element={<Cart />} />
        <Route path="/login" element={<Login />} />
        <Route path="/product" element={<ProductList />} />
        <Route path="/admin" element={<Admin />} />
        <Route path="/admin/products" element={<AdminProductList />} />
        <Route path="/admin/brands" element={<AdminBrandList />} />
      </Routes>

      {!isAdminPage && <Footer />}
    </div>
  );
}

function App() {
  return (
    <Router>
      <Layout />
    </Router>
  );
}

export default App;
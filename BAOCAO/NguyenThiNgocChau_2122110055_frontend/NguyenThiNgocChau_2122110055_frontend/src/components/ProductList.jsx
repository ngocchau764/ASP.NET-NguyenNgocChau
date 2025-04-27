import { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import ProductService from "../services/ProductService";
import { useNavigate } from "react-router-dom";
import CategoryFilter from "./FilterCategory";


const ProductList = () => {
   

    return (
        <div className="p-6">
            <h1 className="text-3xl font-bold text-center text-red-700 mb-4">Danh sách sản phẩm</h1>

            
        

            {/* Danh sách sản phẩm */}
            <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-6">
                
                    <Link
                        to={`/product/${product.id}`}
                        key={product.id}
                        className="block bg-white p-4 shadow rounded-lg hover:shadow-lg transition"
                    >
                        <img
                            src={`http://localhost:8188/laravelapirestfull/public/uploads/products/${product.thumbnail}`}
                            alt={product.name}
                            className="w-full h-40 object-cover rounded"
                        />
                        <h2 className="mt-2 text-xl font-semibold text-center">{product.name}</h2>
                    </Link>
            
            </div>
        </div>
    );
};

export default ProductList;

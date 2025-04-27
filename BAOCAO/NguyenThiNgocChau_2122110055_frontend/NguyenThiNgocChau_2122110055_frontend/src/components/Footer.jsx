import { FaFacebook, FaInstagram, FaTwitter } from "react-icons/fa";

const Footer = () => {
    return (
        <footer className="bg-pink-200 text-black py-6 mt-10">
            <div className="container mx-auto text-center">
                <h2 className="text-2xl font-bold text-black">Ngọc Châu</h2>
                <p className="text-black mt-2">CUNG CẤP CÁC MẶT HÀNG CAO CẤP NHẤT</p>

                {/* Mạng xã hội */}
                <div className="flex justify-center space-x-4 mt-4">
                    <a href="#" className="text-black hover:text-white transition text-xl">
                        <FaFacebook />
                    </a>
                    <a href="#" className="text-black hover:text-white transition text-xl">
                        <FaInstagram />
                    </a>
                    <a href="#" className="text-black hover:text-white transition text-xl">
                        <FaTwitter />
                    </a>
                </div>

                {/* Thông tin liên hệ */}
                <div className="mt-4">
                    <p className="text-black">ĐỊA CHỈ: 1272 KHA VẠN CÂN , TP THỦ ĐỨC</p>
                    <p className="text-black">📞 Hotline: 0123 456 789</p>
                    <p className="text-black">📧 Email: ngocchau@gmail.com</p>
                </div>

                {/* Bản quyền */}
                <p className="text-black mt-4 text-sm">
                    © 2024 SGBakes. All rights reserved.
                </p>
            </div>
        </footer>
    );
};

export default Footer;

import { Link } from "react-router-dom";
import { Phone, Mail, MapPin, Facebook, Twitter, Linkedin, Instagram, Shield } from "lucide-react";

export default function Footer() {
  return (
    <footer className="bg-blue-950 text-white">
      <div className="max-w-7xl mx-auto px-6 py-16">
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-12">

          {/* Column 1: Logo & Tagline */}
          <div>
            <Link to="/" className="flex items-center gap-3 mb-6 group">
              <div className="relative">
                <div className="absolute inset-0 bg-yellow-400 blur-xl opacity-50 group-hover:opacity-70 transition"></div>
                <svg className="w-10 h-10 text-yellow-400 relative" viewBox="0 0 24 24" fill="currentColor">
                  <path d="M4 4h16v16H4z" stroke="currentColor" strokeWidth="2"/>
                </svg>
              </div>
              <span className="text-2xl font-black tracking-tight">TheBank</span>
            </Link>
            <p className="text-yellow-400 font-medium text-sm mb-4">EST. 2005 • PROUDLY SOUTH AFRICAN</p>
            <p className="text-white/80 leading-relaxed">
              Your trusted digital-first bank serving over 500,000 customers nationwide.
            </p>
          </div>

          {/* Column 2: Quick Links */}
          <div>
            <h3 className="text-xl font-bold mb-6 text-yellow-400">Quick Links</h3>
            <ul className="space-y-3">
              <li><Link to="/" className="hover:text-yellow-400 transition">Home</Link></li>
              <li><Link to="/products" className="hover:text-yellow-400 transition">Products</Link></li>
              <li><Link to="/about" className="hover:text-yellow-400 transition">About Us</Link></li>
              <li><Link to="/book" className="hover:text-yellow-400 transition">Book Appointment</Link></li>
            </ul>
          </div>

          {/* Column 3: Contact */}
          <div>
            <h3 className="text-xl font-bold mb-6 text-yellow-400">Contact Us</h3>
            <ul className="space-y-4 text-white/80">
              <li className="flex items-center gap-3">
                <Phone className="w-5 h-5 text-yellow-400" />
                <span>0800 123 456 (Toll-free)</span>
              </li>
              <li className="flex items-center gap-3">
                <Mail className="w-5 h-5 text-yellow-400" />
                <span>hello@Thebank.co.za</span>
              </li>
              <li className="flex items-center gap-3">
                <MapPin className="w-5 h-5 text-yellow-400" />
                <span>20 branches nationwide</span>
              </li>
            </ul>
          </div>

          {/* Column 4: Trust & Social */}
          <div>
            <h3 className="text-xl font-bold mb-6 text-yellow-400">Trust & Connect</h3>
            <div className="space-y-6">
              <div className="flex items-center gap-2 text-sm">
                <Shield className="w-5 h-5 text-yellow-400" />
                <span>Authorised Financial Services Provider</span>
              </div>
              <div className="flex gap-4 mt-6">
                <a href="#" className="w-10 h-10 bg-white/10 rounded-full flex items-center justify-center hover:bg-yellow-400 hover:text-blue-950 transition">
                  <Facebook className="w-5 h-5" />
                </a>
                <a href="#" className="w-10 h-10 bg-white/10 rounded-full flex items-center justify-center hover:bg-yellow-400 hover:text-blue-950 transition">
                  <Twitter className="w-5 h-5" />
                </a>
                <a href="#" className="w-10 h-10 bg-white/10 rounded-full flex items-center justify-center hover:bg-yellow-400 hover:text-blue-950 transition">
                  <Linkedin className="w-5 h-5" />
                </a>
                <a href="#" className="w-10 h-10 bg-white/10 rounded-full flex items-center justify-center hover:bg-yellow-400 hover:text-blue-950 transition">
                  <Instagram className="w-5 h-5" />
                </a>
              </div>
            </div>
          </div>
        </div>

        {/* Bottom Bar */}
        <div className="border-t border-white/10 mt-12 pt-8 flex flex-col md:flex-row justify-between items-center text-sm text-white/70">
          <p>© 2025 TheBank. All rights reserved.</p>
          <div className="flex gap-6 mt-4 md:mt-0">
            <a href="#" className="hover:text-yellow-400 transition">Privacy Policy</a>
            <a href="#" className="hover:text-yellow-400 transition">Terms of Service</a>
            <a href="#" className="hover:text-yellow-400 transition">FSCA License</a>
          </div>
        </div>
      </div>
    </footer>
  );
}
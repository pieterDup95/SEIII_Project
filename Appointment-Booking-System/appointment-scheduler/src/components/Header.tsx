import { Link, useLocation } from "react-router-dom";
import { Banknote, Home, Package, Users, Calendar, Menu, X } from "lucide-react";
import { useState } from "react";

export default function Header() {
  const location = useLocation();
  const [mobileMenuOpen, setMobileMenuOpen] = useState(false);

  const isActive = (path: string) => location.pathname === path;
  const isProductsActive = location.pathname.startsWith("/products");

  const navItems = [
    { to: "/", label: "Home", icon: Home },
    { to: "/products", label: "Products", icon: Package },
    { to: "/about", label: "About Us", icon: Users },
  ];

  return (
    <header className="sticky top-0 z-50 bg-blue-950/95 backdrop-blur-xl border-b border-white/10 shadow-2xl">
      <div className="max-w-7xl mx-auto px-6">
        <div className="flex items-center justify-between h-20">

          {/* Logo */}
          <Link to="/" className="flex items-center gap-3 group">
            <div className="relative">
              <div className="absolute inset-0 bg-yellow-400 blur-xl opacity-60 group-hover:opacity-80 transition"></div>
              <Banknote className="w-12 h-12 text-yellow-400 relative" strokeWidth={2.5} />
            </div>
            <div>
              <h1 className="text-2xl md:text-3xl font-black text-white tracking-tight">
                TheBank
              </h1>
              <p className="text-xs text-yellow-400 font-medium tracking-wider opacity-0 md:opacity-100">
                EST. 2005 • SOUTH AFRICA
              </p>
            </div>
          </Link>

          {/* Desktop Navigation */}
          <nav className="hidden lg:flex items-center gap-10">
            {navItems.map((item) => {
              const Icon = item.icon;
              const active = (item.to === "/" ? isActive("/") : item.to === "/products" ? isProductsActive : isActive(item.to));
              
              return (
                <Link
                  key={item.to}
                  to={item.to}
                  className={`relative flex items-center gap-2.5 text-lg font-medium transition-all duration-300
                    ${active 
                      ? "text-yellow-400" 
                      : "text-white/90 hover:text-yellow-400"
                    }`}
                >
                  <Icon className="w-5 h-5" />
                  {item.label}
                  {active && (
                    <span className="absolute -bottom-8 left-0 w-full h-1 bg-gradient-to-r from-yellow-400 to-yellow-300 rounded-full"></span>
                  )}
                </Link>
              );
            })}

            {/* CTA Button */}
            <Link
              to="/book"
              className="ml-8 bg-yellow-400 text-blue-950 px-8 py-4 rounded-2xl font-bold text-lg
                       flex items-center gap-3 shadow-xl hover:shadow-yellow-400/50
                       transform hover:scale-105 transition-all duration-300"
            >
              <Calendar className="w-6 h-6" />
              Book Appointment
            </Link>
          </nav>

          {/* Mobile Menu Button */}
          <button
            onClick={() => setMobileMenuOpen(!mobileMenuOpen)}
            className="lg:hidden text-white p-2"
          >
            {mobileMenuOpen ? <X className="w-8 h-8" /> : <Menu className="w-8 h-8" />}
          </button>
        </div>

        {/* MOBILE MENU — FIXED: solid white background + dark text */}
        {mobileMenuOpen && (
          <>
            {/* Dark backdrop */}
            <div 
              className="fixed inset-0 bg-black bg-opacity-70 z-40"
              onClick={() => setMobileMenuOpen(false)}
            />

            {/* Menu panel — now SOLID WHITE */}
            <div className="fixed inset-x-0 top-20 z-50 bg-white shadow-2xl rounded-b-3xl overflow-hidden">
              <nav className="py-8 px-6 space-y-1">
                {navItems.map((item) => {
                  const Icon = item.icon;
                  const active = (item.to === "/" ? isActive("/") : item.to === "/products" ? isProductsActive : isActive(item.to));
                  
                  return (
                    <Link
                      key={item.to}
                      to={item.to}
                      onClick={() => setMobileMenuOpen(false)}
                      className={`flex items-center gap-4 text-xl font-semibold py-4 px-5 rounded-2xl transition-all
                        ${active 
                          ? "bg-yellow-400 text-blue-950 shadow-lg" 
                          : "text-gray-800 hover:bg-gray-100"
                        }`}
                    >
                      <Icon className={`w-7 h-7 ${active ? "text-blue-950" : "text-gray-600"}`} />
                      {item.label}
                    </Link>
                  );
                })}
                
                <Link
                  to="/book"
                  onClick={() => setMobileMenuOpen(false)}
                  className="mt-6 block bg-yellow-400 text-blue-950 px-8 py-5 rounded-2xl font-bold text-xl text-center
                           shadow-xl hover:shadow-yellow-400/50 transform hover:scale-105 transition-all duration-300
                           flex items-center justify-center gap-3 mx-4"
                >
                  <Calendar className="w-8 h-8" />
                  Book Appointment
                </Link>
              </nav>
            </div>
          </>
        )}
      </div>
    </header>
  );
}
// src/pages/Home.tsx
import { Link } from "react-router-dom";
import {
  CreditCard,
  Home as HomeIcon,
  PiggyBank,
  TrendingUp,
  ArrowRight,
  Shield,
  Clock,
  Users,
  Award,
  HeadphonesIcon,
  Globe,
  CheckCircle2,
} from "lucide-react";

const HERO_BG =
  "https://images.unsplash.com/photo-1579621970795-87facc2f976d?ixlib=rb-4.0.3&auto=format&fit=crop&w=2400&q=90";

const products = [
  {
    id: "personal-loans",
    title: "Personal Loans",
    description: "Flexible loans from R5,000 – R350,000 with fixed rates and same-day approval.",
    icon: TrendingUp,
    gradient: "from-purple-500 to-purple-600",
  },
  {
    id: "home-loans",
    title: "Home Loans",
    description: "Up to 100% bonds, low rates, and expert guidance for first-time buyers.",
    icon: HomeIcon,
    gradient: "from-emerald-500 to-teal-600",
  },
  {
    id: "savings",
    title: "Savings & Investments",
    description: "Earn up to 9.5% interest p.a. with capital-guaranteed options.",
    icon: PiggyBank,
    gradient: "from-amber-500 to-orange-600",
  },
  {
    id: "credit-cards",
    title: "Credit Cards",
    description: "Premium rewards, up to 55 days interest-free, and global travel benefits.",
    icon: CreditCard,
    gradient: "from-blue-600 to-indigo-700",
  },
];

const features = [
  { title: "256-bit Encryption", description: "Bank-grade security protecting every transaction.", icon: Shield },
  { title: "24/7 Local Support", description: "Real South African experts, anytime you need us.", icon: HeadphonesIcon },
  { title: "Instant Approvals", description: "Many loans approved and paid out within hours.", icon: Clock },
  { title: "500,000+ Customers", description: "Trusted nationwide from Cape Town to Polokwane.", icon: Users },
  { title: "Award-Winning Bank", description: "Best Digital Bank SA 2024 – Finance Weekly Awards.", icon: Award },
  { title: "20 Branches", description: "Bank online or visit us — the choice is yours.", icon: Globe },
];

export default function Home() {
  return (
    <>
      {/* Premium Hero Section */}
      <section className="relative min-h-screen flex items-center justify-center overflow-hidden">
        <div
          className="absolute inset-0 bg-cover bg-center bg-no-repeat"
          style={{ backgroundImage: `url(${HERO_BG})` }}
        />
        <div className="absolute inset-0 bg-gradient-to-br from-blue-950/95 via-blue-900/90 to-indigo-950/95" />
        
        <div className="relative z-10 max-w-7xl mx-auto px-6 text-center text-white">
          <div className="animate-fade-in">
            <p className="text-yellow-400 font-medium text-lg tracking-wider mb-4">SOUTH AFRICA'S TRUSTED DIGITAL BANK</p>
            <h1 className="text-5xl md:text-7xl font-black tracking-tight mb-8 leading-tight">
              Banking That<br />
              <span className="text-transparent bg-clip-text bg-gradient-to-r from-yellow-400 to-yellow-200">
                Works For You
              </span>
            </h1>
            <p className="text-xl md:text-2xl max-w-4xl mx-auto opacity-90 leading-relaxed mb-12">
              Secure, simple, and fast banking — proudly South African since 2005.
            </p>
          </div>
        </div>

        {/* Elegant Wave Divider */}
        <div className="absolute bottom-0 left-0 right-0">
          <svg viewBox="0 0 1440 150" className="w-full h-32 md:h-48" preserveAspectRatio="none">
            <path
              d="M0,0 L48,48 L96,32 L144,64 L240,48 L336,80 L432,64 L528,96 L624,48 L720,80 L816,64 L912,96 L1008,48 L1104,80 L1200,64 L1296,96 L1392,48 L1440,80 V150 H0 V0"
              fill="white"
            />
          </svg>
        </div>
      </section>

      {/* Why Choose TheBank – Premium Grid */}
      <section className="py-24 lg:py-32 bg-white">
        <div className="max-w-7xl mx-auto px-6">
          <div className="text-center mb-16 lg:mb-20">
            <h2 className="text-4xl md:text-6xl font-black text-gray-900 mb-6">
              Why South Africans Choose Us
            </h2>
            <p className="text-xl text-gray-600 max-w-3xl mx-auto">
              We combine cutting-edge technology with old-school service you can trust.
            </p>
          </div>

          <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-10">
            {features.map((feature) => {
              const Icon = feature.icon;
              return (
                <div
                  key={feature.title}
                  className="group relative bg-gradient-to-br from-gray-50 to-gray-100 rounded-3xl p-8 hover:shadow-2xl hover:-translate-y-2 transition-all duration-500 border border-gray-200"
                >
                  <div className="absolute inset-0 bg-gradient-to-br from-blue-600/5 to-purple-600/5 rounded-3xl opacity-0 group-hover:opacity-100 transition-opacity" />
                  <div className="relative">
                    <div className="w-16 h-16 bg-gradient-to-br from-blue-600 to-indigo-700 rounded-2xl flex items-center justify-center mb-6 shadow-lg">
                      <Icon className="w-9 h-9 text-white" />
                    </div>
                    <h3 className="text-2xl font-bold text-gray-900 mb-3">{feature.title}</h3>
                    <p className="text-gray-600 leading-relaxed">{feature.description}</p>
                    <CheckCircle2 className="w-6 h-6 text-yellow-500 mt-4 opacity-0 group-hover:opacity-100 transition-opacity" />
                  </div>
                </div>
              );
            })}
          </div>
        </div>
      </section>

      {/* Products Showcase */}
      <section className="py-24 lg:py-32 bg-gradient-to-b from-gray-50 to-white">
        <div className="max-w-7xl mx-auto px-6">
          <div className="text-center mb-16 lg:mb-20">
            <h2 className="text-4xl md:text-6xl font-black text-gray-900 mb-6">
              Products Designed For You
            </h2>
            <p className="text-xl text-gray-600">Simple. Transparent. Powerful.</p>
          </div>

          <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8">
            {products.map((product) => {
              const Icon = product.icon;
              return (
                <Link
                  key={product.id}
                  to={`/products/${product.id}`}
                  className="group relative bg-white rounded-3xl shadow-xl hover:shadow-2xl overflow-hidden transition-all duration-500 hover:-translate-y-3 border border-gray-100"
                >
                  <div className={`h-40 bg-gradient-to-br ${product.gradient} relative overflow-hidden`}>
                    <div className="absolute inset-0 bg-black/10" />
                    <Icon className="absolute top-1/2 left-1/2 -translate-x-1/2 -translate-y-1/2 w-20 h-20 text-white/90 group-hover:scale-110 transition-transform duration-500" />
                  </div>
                  <div className="p-8">
                    <h3 className="text-2xl font-bold text-gray-900 mb-3 group-hover:text-blue-700 transition">
                      {product.title}
                    </h3>
                    <p className="text-gray-600 leading-relaxed mb-6">
                      {product.description}
                    </p>
                    <div className="flex items-center text-blue-600 font-semibold group-hover:gap-3 transition-all">
                      Learn more <ArrowRight className="w-5 h-5 ml-2 group-hover:translate-x-2 transition" />
                    </div>
                  </div>
                </Link>
              );
            })}
          </div>

          <div className="text-center mt-16">
            <Link
              to="/products"
              className="inline-flex items-center gap-3 text-blue-600 font-bold text-lg hover:text-blue-800 transition"
            >
              Explore All Products <ArrowRight className="w-6 h-6" />
            </Link>
          </div>
        </div>
      </section>

      {/* Final CTA – Premium */}
      <section className="relative py-32 bg-gradient-to-br from-blue-950 via-blue-900 to-indigo-950 text-white overflow-hidden">
        <div className="absolute inset-0 bg-grid-white/5" />
        <div className="relative max-w-5xl mx-auto text-center px-6">
          <h2 className="text-5xl md:text-7xl font-black mb-8 leading-tight">
            Your Financial Future<br />
            <span className="text-transparent bg-clip-text bg-gradient-to-r from-yellow-400 to-yellow-200">
              Starts Today
            </span>
          </h2>
          <p className="text-xl md:text-2xl opacity-90 mb-12 max-w-3xl mx-auto">
            Join over 500,000 South Africans who bank smarter with TheBank.
          </p>
          <Link
            to="/book"
            className="inline-flex items-center gap-4 bg-yellow-400 text-blue-950 px-12 py-7 rounded-2xl text-2xl font-bold hover:bg-yellow-300 transition-all shadow-2xl hover:shadow-yellow-400/50 transform hover:scale-105"
          >
            Book Appointment
            <ArrowRight className="w-8 h-8" />
          </Link> 
        </div>
      </section>
    </>
  );
}
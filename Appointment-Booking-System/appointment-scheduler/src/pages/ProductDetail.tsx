// src/pages/ProductDetail.tsx
import { useParams, Link } from "react-router-dom";
import { ArrowLeft, Check,  Shield } from "lucide-react";

interface Product {
  title: string;
  subtitle: string;
  rate: string;
  amount: string;
  term: string;
  features: string[];
  eligibility: string[];
  gradient: string;
}

const productData: Record<string, Product> = {
  "personal-loans": {
    title: "Personal Loans",
    subtitle: "Fast, flexible funding for whatever life brings",
    rate: "From 9.99% p.a.",
    amount: "R5,000 – R350,000",
    term: "12 – 84 months",
    gradient: "from-purple-500 to-purple-600",
    features: [
      "Same-day approval & payout",
      "No hidden fees or penalties",
      "Flexible repayment schedules",
      "Early settlement allowed – no charge",
    ],
    eligibility: [
      "18+ years old",
      "Monthly income R8,000+",
      "Valid South African ID",
      "Clean or reparable credit record",
    ],
  },
  "home-loans": {
    title: "Home Loans",
    subtitle: "Your dream home starts here",
    rate: "As low as Prime – 1.5% (currently 9.25%)",
    amount: "R500,000 – R20,000,000+",
    term: "20 – 30 years",
    gradient: "from-emerald-500 to-teal-600",
    features: [
      "100% bonds available",
      "Dedicated bond originator support",
      "Fixed or variable rate options",
      "Free online pre-approval in minutes",
    ],
    eligibility: [
      "Stable employment or income",
      "Credit score 600+ preferred",
      "Affordability assessment",
      "South African citizen or permanent resident",
    ],
  },
  "savings": {
    title: "Savings & Investments",
    subtitle: "Grow your wealth safely and predictably",
    rate: "Up to 9.5% interest p.a.",
    amount: "From R1,000 (no maximum)",
    term: "Flexible – access anytime",
    gradient: "from-amber-500 to-orange-600",
    features: [
      "Top-tier interest rates in SA",
      "Zero monthly or withdrawal fees",
      "Capital 100% guaranteed",
      "Tax-free options available",
    ],
    eligibility: [
      "Anyone 18 years or older",
      "Valid ID or passport",
      "South African bank account",
      "No credit check required",
    ],
  },
  "credit-cards": {
    title: "Credit Cards",
    subtitle: "Premium rewards, global acceptance",
    rate: "From 15% p.a. (revolving)",
    amount: "Credit limit up to R500,000",
    term: "Revolving credit",
    gradient: "from-blue-600 to-indigo-700",
    features: [
      "Up to 5% cashback on purchases",
      "55 days interest-free",
      "Complimentary travel insurance",
      "Exclusive partner discounts",
    ],
    eligibility: [
      "Monthly income R8,000+",
      "Good credit history",
      "18+ with valid SA ID",
      "Proof of income",
    ],
  },
};

export default function ProductDetail() {
  const { productId } = useParams<{ productId: string }>();
  const product = productId ? productData[productId] : null;

  if (!product) {
    return (
      <div className="min-h-screen flex items-center justify-center bg-gradient-to-b from-gray-50 to-white">
        <div className="text-center">
          <h2 className="text-4xl font-black text-gray-900 mb-6">Product Not Found</h2>
          <Link to="/products" className="text-blue-600 font-bold text-lg hover:underline">
            ← Back to All Products
          </Link>
        </div>
      </div>
    );
  }

  return (
    <>
      {/* Premium Hero */}
      <section className="relative py-32 bg-gradient-to-br from-blue-950 via-blue-900 to-indigo-950 text-white overflow-hidden">
        <div className="absolute inset-0 bg-grid-white/5" />
        <div className="relative max-w-7xl mx-auto px-6">
          <Link
            to="/products"
            className="inline-flex items-center gap-2 text-yellow-400 font-medium hover:underline mb-8"
          >
            <ArrowLeft className="w-5 h-5" /> Back to Products
          </Link>

          <div className="grid lg:grid-cols-2 gap-12 items-center">
            <div>
              <p className="text-yellow-400 font-medium tracking-wider mb-4">PRODUCT DETAIL</p>
              <h1 className="text-5xl md:text-7xl font-black mb-6 leading-tight">
                {product.title}
              </h1>
              <p className="text-2xl opacity-90 max-w-2xl">{product.subtitle}</p>
            </div>

            {/* Gradient Icon */}
            <div className={`h-64 w-64 bg-gradient-to-br ${product.gradient} rounded-3xl flex items-center justify-center mx-auto shadow-2xl`}>
              <div className="bg-white/20 backdrop-blur-sm rounded-3xl w-52 h-52 flex items-center justify-center">
                <div className="bg-white/30 backdrop-blur-md rounded-3xl w-40 h-40" />
              </div>
            </div>
          </div>
        </div>

        <div className="absolute bottom-0 left-0 right-0">
          <svg viewBox="0 0 1440 150" className="w-full h-32 md:h-48" preserveAspectRatio="none">
            <path d="M0,0 L48,48 L96,32 L144,64 L240,48 L336,80 L432,64 L528,96 L624,48 L720,80 L816,64 L912,96 L1008,48 L1104,80 L1200,64 L1296,96 L1392,48 L1440,80 V150 H0 V0" fill="white" />
          </svg>
        </div>
      </section>

      {/* Main Content */}
      <section className="py-20 lg:py-28 bg-gradient-to-b from-gray-50 to-white">
        <div className="max-w-7xl mx-auto px-6">
          <div className="grid lg:grid-cols-3 gap-12">
            {/* Left: Details */}
            <div className="lg:col-span-2 space-y-12">
              {/* Key Features */}
              <div className="bg-white rounded-3xl shadow-xl p-10 border border-gray-100">
                <h2 className="text-4xl font-black text-gray-900 mb-10">Key Features & Benefits</h2>
                <div className="grid md:grid-cols-2 gap-8">
                  {product.features.map((feature, i) => (
                    <div key={i} className="flex items-start gap-5">
                      <Check className="w-8 h-8 text-yellow-500 flex-shrink-0 mt-1" />
                      <span className="text-lg text-gray-700 leading-relaxed">{feature}</span>
                    </div>
                  ))}
                </div>
              </div>

              {/* Eligibility */}
              <div className="bg-white rounded-3xl shadow-xl p-10 border border-gray-100">
                <h2 className="text-4xl font-black text-gray-900 mb-10">Eligibility Requirements</h2>
                <ul className="space-y-5">
                  {product.eligibility.map((item, i) => (
                    <li key={i} className="flex items-center gap-5">
                      <div className="w-4 h-4 bg-yellow-500 rounded-full flex-shrink-0" />
                      <span className="text-lg text-gray-700">{item}</span>
                    </li>
                  ))}
                </ul>
              </div>
            </div>

            {/* Right: Sticky CTA Card */}
            <div className="lg:col-start-3">
              <div className="sticky top-24 bg-white rounded-3xl shadow-2xl border border-gray-200 overflow-hidden">
                <div className={`h-3 bg-gradient-to-r ${product.gradient}`} />
                <div className="p-10">
                  <h3 className="text-3xl font-black text-center mb-10">At a Glance</h3>

                  <div className="space-y-8 text-lg">
                    <div className="flex justify-between">
                      <span className="text-gray-600">Interest Rate</span>
                      <span className="font-bold text-gray-900">{product.rate}</span>
                    </div>
                    <div className="flex justify-between">
                      <span className="text-gray-600">Amount</span>
                      <span className="font-bold text-gray-900">{product.amount}</span>
                    </div>
                    <div className="flex justify-between">
                      <span className="text-gray-600">Term</span>
                      <span className="font-bold text-gray-900">{product.term}</span>
                    </div>
                  </div>


                  <div className="mt-10 pt-8 border-t text-center">
                    <div className="flex items-center justify-center gap-2 text-green-600 font-semibold mb-2">
                      <Shield className="w-5 h-5" /> 100% Safe & Regulated
                    </div>
                    <p className="text-sm text-gray-500">Authorised Financial Services Provider • FSCA licensed</p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>
    </>
  );
}
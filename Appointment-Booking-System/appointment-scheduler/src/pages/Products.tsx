import { Link } from "react-router-dom";
import { TrendingUp, Home, PiggyBank, CreditCard, ArrowRight, Check } from "lucide-react";

const products = [
  {
    id: "personal-loans",
    title: "Personal Loans",
    icon: TrendingUp,
    gradient: "from-purple-500 to-purple-600",
    highlights: [
      "Rates from just 9.99% p.a.",
      "Borrow R5,000 – R350,000",
      "Flexible 12–84 month terms",
      "Same-day payout possible",
    ],
  },
  {
    id: "home-loans",
    title: "Home Loans",
    icon: Home,
    gradient: "from-emerald-500 to-teal-600",
    highlights: [
      "As low as Prime –1.5%",
      "100% bonds available",
      "20–30 year terms",
      "Free pre-approval in 5 mins",
    ],
  },
  {
    id: "savings",
    title: "Savings & Investments",
    icon: PiggyBank,
    gradient: "from-amber-500 to-orange-600",
    highlights: [
      "Earn up to 9.5% interest p.a.",
      "Zero monthly fees",
      "Instant access anytime",
      "Capital 100% guaranteed",
    ],
  },
  {
    id: "credit-cards",
    title: "Credit Cards",
    icon: CreditCard,
    gradient: "from-blue-600 to-indigo-700",
    highlights: [
      "Up to 5% cashback",
      "55 days interest-free",
      "Free travel insurance",
      "No annual fee options",
    ],
  },
];

export default function Products() {
  return (
    <>
      {/* Hero Banner */}
      <section className="relative py-32 bg-gradient-to-br from-blue-950 via-blue-900 to-indigo-950 text-white overflow-hidden">
        <div className="absolute inset-0 bg-grid-white/5" />
        <div className="relative max-w-7xl mx-auto px-6 text-center">
          <p className="text-yellow-400 font-medium tracking-wider mb-4">ALL PRODUCTS • ONE BANK</p>
          <h1 className="text-5xl md:text-7xl font-black mb-6 leading-tight">
            Choose the Right Product<br />
            <span className="text-transparent bg-clip-text bg-gradient-to-r from-yellow-400 to-yellow-200">
              For Your Goals
            </span>
          </h1>
          <p className="text-xl md:text-2xl opacity-90 max-w-3xl mx-auto">
            Transparent rates. No hidden fees. Built for South Africans, by South Africans.
          </p>
        </div>

        {/* Wave */}
        <div className="absolute bottom-0 left-0 right-0">
          <svg viewBox="0 0 1440 150" className="w-full h-32 md:h-48" preserveAspectRatio="none">
            <path
              d="M0,0 L48,48 L96,32 L144,64 L240,48 L336,80 L432,64 L528,96 L624,48 L720,80 L816,64 L912,96 L1008,48 L1104,80 L1200,64 L1296,96 L1392,48 L1440,80 V150 H0 V0"
              fill="white"
            />
          </svg>
        </div>
      </section>

      {/* Products Grid – Premium Cards */}
      <section className="py-24 lg:py-32 bg-gradient-to-b from-gray-50 to-white">
        <div className="max-w-7xl mx-auto px-6">
          <div className="grid lg:grid-cols-2 gap-10 lg:gap-12">
            {products.map((product) => {
              const Icon = product.icon;
              return (
                <Link
                  key={product.id}
                  to={`/products/${product.id}`}
                  className="group relative bg-white rounded-3xl shadow-xl hover:shadow-2xl overflow-hidden transition-all duration-500 hover:-translate-y-3 border border-gray-100"
                >
                  {/* Gradient Top Bar */}
                  <div className={`h-32 bg-gradient-to-br ${product.gradient} relative overflow-hidden`}>
                    <div className="absolute inset-0 bg-black/10" />
                    <Icon className="absolute top-1/2 left-1/2 -translate-x-1/2 -translate-y-1/2 w-24 h-24 text-white/90 group-hover:scale-110 transition-transform duration-500" />
                  </div>

                  {/* Content */}
                  <div className="p-10 lg:p-12">
                    <h2 className="text-3xl lg:text-4xl font-black text-gray-900 mb-8 group-hover:text-blue-700 transition">
                      {product.title}
                    </h2>

                    <ul className="space-y-5 mb-10">
                      {product.highlights.map((highlight, i) => (
                        <li key={i} className="flex items-start gap-4">
                          <Check className="w-6 h-6 text-yellow-500 flex-shrink-0 mt-0.5" />
                          <span className="text-lg text-gray-700 leading-relaxed">{highlight}</span>
                        </li>
                      ))}
                    </ul>

                    <div className="flex items-center text-blue-600 font-bold text-lg group-hover:text-blue-700 transition-all">
                      View Full Details
                      <ArrowRight className="w-6 h-6 ml-3 group-hover:translate-x-3 transition-transform duration-300" />
                    </div>
                  </div>

                  {/* Hover glow effect */}
                  <div className="absolute inset-0 rounded-3xl bg-gradient-to-br from-blue-600/5 to-purple-600/5 opacity-0 group-hover:opacity-100 transition-opacity pointer-events-none" />
                </Link>
              );
            })}
          </div>

          {/* Bottom CTA */}
          <div className="text-center mt-20">
            <p className="text-xl text-gray-600 mb-8">
              Not sure which product is right for you?
            </p>
            <Link
              to="/book"
              className="inline-flex items-center gap-4 bg-yellow-400 text-blue-950 px-10 py-6 rounded-2xl text-xl font-bold hover:bg-yellow-300 transition-all shadow-xl hover:shadow-yellow-400/50 transform hover:scale-105"
            >
              Get Free Expert Advice Today
              <ArrowRight className="w-7 h-7" />
            </Link>
          </div>
        </div>
      </section>
    </>
  );
}
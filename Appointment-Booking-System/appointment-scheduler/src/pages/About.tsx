// src/pages/About.tsx
import { Users, Shield, Target, Heart, TrendingUp, Globe } from "lucide-react";

export default function About() {
  return (
    <> 
      <section className="relative py-32 bg-gradient-to-br from-blue-950 via-blue-900 to-indigo-950 text-white overflow-hidden">
        <div className="absolute inset-0 bg-grid-white/5" />
        <div className="relative max-w-7xl mx-auto px-6 text-center">
          <p className="text-yellow-400 font-medium tracking-wider mb-4">PROUDLY SOUTH AFRICAN SINCE 2005</p>
          <h1 className="text-5xl md:text-7xl font-black mb-8 leading-tight">
            Banking That Feels<br />
            <span className="text-transparent bg-clip-text bg-gradient-to-r from-yellow-400 to-yellow-200">
              Like Home
            </span>
          </h1>
          <p className="text-xl md:text-2xl opacity-90 max-w-4xl mx-auto leading-relaxed">
            Trusted by over 500,000 South Africans · Regulated by the SARB & FSCA · Built for every province, every dream
          </p>
        </div>
 
        <div className="absolute bottom-0 left-0 right-0">
          <svg viewBox="0 0 1440 150" className="w-full h-32 md:h-48" preserveAspectRatio="none">
            <path
              d="M0,0 L48,48 L96,32 L144,64 L240,48 L336,80 L432,64 L528,96 L624,48 L720,80 L816,64 L912,96 L1008,48 L1104,80 L1200,64 L1296,96 L1392,48 L1440,80 V150 H0 V0"
              fill="white"
            />
          </svg>
        </div>
      </section>

      {/* journey */}
      <section className="py-24 lg:py-32 bg-white">
        <div className="max-w-5xl mx-auto px-6 text-center">
          <h2 className="text-4xl md:text-6xl font-black text-gray-900 mb-12">
            Our Journey So Far
          </h2>
          <div className="grid md:grid-cols-3 gap-12 text-left text-lg text-gray-700 leading-relaxed">
            <div className="space-y-6">
              <p className="text-2xl font-bold text-blue-700">2005 – Born in Cape Town</p>
              <p>A small team with a big idea: banking should be fair, fast, and human.</p>
            </div>
            <div className="space-y-6">
              <p className="text-2xl font-bold text-blue-700">2015 – Digital Revolution</p>
              <p>Launched SA’s first fully online loan application. Approvals in hours, not weeks.</p>
            </div>
            <div className="space-y-6">
              <p className="text-2xl font-bold text-blue-700">Today – Nationwide Leader</p>
              <p>500,000+ customers · 20 branches · R15 billion+ in assets · Still 100% South African owned</p>
            </div>
          </div>
          <p className="mt-16 text-2xl md:text-3xl font-bold text-center text-blue-800 max-w-4xl mx-auto">
            We didn’t just join the banking industry.<br />We changed it — for the better.
          </p>
        </div>
      </section>

      {/* values*/}
      <section className="py-24 lg:py-32 bg-gradient-to-b from-gray-50 to-white">
        <div className="max-w-7xl mx-auto px-6">
          <h2 className="text-4xl md:text-6xl font-black text-center text-gray-900 mb-16">
            Our Values Define Us
          </h2>
          <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-10">
            {[
              { icon: Users, title: "Customer First", desc: "Your goals are our only KPI", color: "from-blue-500 to-blue-600" },
              { icon: Shield, title: "Unbreakable Trust", desc: "Bank-grade security, every second", color: "from-purple-500 to-purple-600" },
              { icon: TrendingUp, title: "Relentless Innovation", desc: "Tomorrow’s banking, today", color: "from-emerald-500 to-teal-600" },
              { icon: Heart, title: "Community at Heart", desc: "We grow when South Africa grows", color: "from-amber-500 to-orange-600" },
            ].map((value) => {
              const Icon = value.icon;
              return (
                <div
                  key={value.title}
                  className="group relative bg-white rounded-3xl shadow-xl p-10 text-center hover:shadow-2xl hover:-translate-y-3 transition-all duration-500 border border-gray-100"
                >
                  <div className={`w-24 h-24 mx-auto mb-8 rounded-3xl bg-gradient-to-br ${value.color} flex items-center justify-center shadow-lg`}>
                    <Icon className="w-14 h-14 text-white" />
                  </div>
                  <h3 className="text-2xl font-black text-gray-900 mb-4">{value.title}</h3>
                  <p className="text-gray-600 text-lg leading-relaxed">{value.desc}</p>
                </div>
              );
            })}
          </div>
        </div>
      </section>

      {/* team */}
      <section className="py-24 lg:py-32 bg-white">
        <div className="max-w-7xl mx-auto px-6">
          <h2 className="text-4xl md:text-6xl font-black text-center text-gray-900 mb-16">
            Meet Our Leadership
          </h2>
          <div className="grid md:grid-cols-3 gap-12 max-w-5xl mx-auto">
            {[
              { name: "Piet Pogenpoel", role: "CEO & Founder", icon: Users, gradient: "from-blue-600 to-cyan-600" },
              { name: "Sani Maree", role: "Chief Financial Officer", icon: Target, gradient: "from-purple-600 to-pink-600" },
              { name: "Akhona Dlamini", role: "Chief Technology Officer", icon: Globe, gradient: "from-emerald-600 to-teal-600" },
            ].map((leader) => {
              const Icon = leader.icon;
              return (
                <div key={leader.name} className="text-center group">
                  <div className={`w-48 h-48 mx-auto mb-8 rounded-3xl bg-gradient-to-br ${leader.gradient} p-1 shadow-2xl`}>
                    <div className="w-full h-full bg-white rounded-3xl flex items-center justify-center">
                      <Icon className="w-24 h-24 text-gray-800" />
                    </div>
                  </div>
                  <h3 className="text-3xl font-black text-gray-900">{leader.name}</h3>
                  <p className="text-xl font-semibold text-blue-600 mt-2">{leader.role}</p>
                </div>
              );
            })}
          </div>
        </div>
      </section>

      {/* stats */}
      <section className="py-28 bg-gradient-to-br from-blue-950 via-blue-900 to-indigo-950 text-white">
        <div className="max-w-7xl mx-auto px-6">
          <div className="grid grid-cols-2 md:grid-cols-4 gap-12 text-center">
            {[
              { number: "19+", label: "Years of Excellence" },
              { number: "500K+", label: "Happy Customers" },
              { number: "20", label: "Branches Nationwide" },
            ].map((stat) => (
              <div key={stat.label}>
                <div className="text-6xl md:text-7xl font-black text-yellow-400">{stat.number}</div>
                <p className="text-xl md:text-2xl mt-4 opacity-90">{stat.label}</p>
              </div>
            ))}
          </div>
        </div>
      </section>

      <section className="py-32 bg-gradient-to-b from-gray-50 to-white text-center">
        <div className="max-w-4xl mx-auto px-6">
          <h2 className="text-5xl md:text-6xl font-black text-gray-900 mb-8">
            Ready to Bank Better?
          </h2>
          <p className="text-xl text-gray-600 mb-12">
            Join thousands of South Africans who switched and never looked back.
          </p>
          <a
            href="/book"
            className="inline-flex items-center gap-4 bg-yellow-400 text-blue-950 px-12 py-7 rounded-2xl text-2xl font-bold hover:bg-yellow-300 transition-all shadow-2xl hover:shadow-yellow-400/50 transform hover:scale-105"
          >
            Open Your Account Today
          </a>
        </div>
      </section>
    </>
  );
}
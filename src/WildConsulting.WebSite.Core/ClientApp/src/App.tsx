import { Navbar } from './components/layout/Navbar';
import { Footer } from './components/layout/Footer';
import { HeroSection } from './components/sections/HeroSection';
import { ServicesSection } from './components/sections/ServicesSection';
import { AboutSection } from './components/sections/AboutSection';
import { SkillsSection } from './components/sections/SkillsSection';
import { ContactSection } from './components/sections/ContactSection';

function App() {
  return (
    <>
      <Navbar />
      <div id="main" className="container">
        <HeroSection />
        <ServicesSection />
        <AboutSection />
        <SkillsSection />
        <ContactSection />
      </div>
      <Footer />
    </>
  );
}

export default App;

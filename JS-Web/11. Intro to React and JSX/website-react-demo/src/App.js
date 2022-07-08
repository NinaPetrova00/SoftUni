import { HeroSection } from './components/HeroSection';
import { AboutSection } from './components/AboutSection';
import { ServiceSection } from './components/ServiceSection';
import { PortfolioSection } from './components/PortfolioSection';
import { NewsSection } from './components/NewsSection';
import { SubscribeSection } from './components/SubscribeSection';
import { ClientSection } from './components/ClientSection';
import { ContactSection } from './components/ContactSection';
import { InfoSection } from './components/InfoSection';
import { FooterSection } from './components/FooterSection';

function App() {
  return (
    <div>
      <HeroSection />

      {/* about section */}
      <AboutSection />

      {/* service section */}
      <ServiceSection />

      {/* portfolio section */}
      <PortfolioSection />

      {/* news section */}
      <NewsSection />

      {/* subscribe section */}
      <SubscribeSection />

      {/* client section */}
      <ClientSection />

      {/* contact section */}
      <ContactSection />

      {/* info section */}
      <InfoSection />

      {/* footer section */}
      <FooterSection />

    </div>
  );
}

export default App;

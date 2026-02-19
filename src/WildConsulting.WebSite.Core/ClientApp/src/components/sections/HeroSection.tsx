export const HeroSection = () => {
  return (
    <section id="home" className="hero-section">
      <div className="row align-items-start pt-5 pb-2">
        <div className="col-lg-4 text-center mb-4 mb-lg-0">
          <img
            className="hero-logo"
            src="/images/wild-consulting-logo.png"
            alt="Wild Consulting Limited"
          />
        </div>
        <div className="col-lg-8">
          <h1 className="display-4 fw-bold mb-4">Wild Consulting Limited</h1>
          <p className="lead mb-3">
            Expert .NET and Azure software consulting based in Oxford, specializing in Azure cloud, ASP.NET Core, and modern AI-driven solutions.
          </p>
          <p className="mb-4">
            Enterprise-grade systems for government, banking, and insurance sectors since 2008.
          </p>
          <a className="btn btn-primary btn-lg" href="#contact">Get in Touch</a>
        </div>
      </div>
    </section>
  );
};

export const SkillsSection = () => {
  return (
    <section id="skills" className="skills-section py-5">
      <div className="text-center mb-5">
        <h2 className="display-5 fw-bold">Technical Expertise</h2>
        <p className="lead text-muted">Core skills and emerging technologies</p>
      </div>

      <div className="row">
        <div className="col-lg-6 mb-4">
          <h3 className="h4 mb-3">Core Skills</h3>
          <div className="row g-2">
            <div className="col-md-6">
              <ul className="list-unstyled">
                <li className="mb-2"><strong>.NET &amp; C#:</strong> ASP.NET Core MVC, Razor Pages, Web APIs</li>
                <li className="mb-2"><strong>Azure:</strong> App Services, Functions, ServiceBus, Storage, Key Vault</li>
                <li className="mb-2"><strong>Databases:</strong> SQL Server, Cosmos DB, EF Core, Dapper</li>
                <li className="mb-2"><strong>CI/CD:</strong> Azure DevOps, YAML pipelines, Bicep, ARM</li>
              </ul>
            </div>
            <div className="col-md-6">
              <ul className="list-unstyled">
                <li className="mb-2"><strong>Web:</strong> HTML, JavaScript, CSS</li>
                <li className="mb-2"><strong>Resilience:</strong> Polly, Microsoft Resilience</li>
                <li className="mb-2"><strong>Testing:</strong> xUnit, Moq, NSubstitute</li>
                <li className="mb-2"><strong>Agile:</strong> GDS, Scrum</li>
              </ul>
            </div>
          </div>
        </div>

        <div className="col-lg-6 mb-4">
          <h3 className="h4 mb-3">Emerging Skills &amp; Interests</h3>
          <div className="row g-2">
            <div className="col-md-6">
              <ul className="list-unstyled">
                <li className="mb-2"><strong>AI &amp; ML:</strong> Semantic Kernel, Agent Framework, Azure OpenAI</li>
                <li className="mb-2"><strong>RAG:</strong> Retrieval Augmented Generation, Graph RAG with Neo4j</li>
              </ul>
            </div>
            <div className="col-md-6">
              <ul className="list-unstyled">
                <li className="mb-2"><strong>Modern Dev:</strong> Docker, .NET Aspire, GitHub Copilot, Claude Code</li>
                <li className="mb-2"><strong>Data Science:</strong> Python, R, Microsoft Fabric, geospatial analytics</li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

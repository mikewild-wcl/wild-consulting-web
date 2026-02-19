export const Footer = () => {
  const currentYear = new Date().getFullYear();

  return (
    <footer className="py-5 bg-dark">
      <div className="container">
        <p className="m-0 text-center text-white">
          Copyright &copy; Wild Consulting Limited {currentYear}
        </p>
        <p className="m-0 text-center text-white">
          <small>Running on React + ASP.NET Core</small>
        </p>
      </div>
    </footer>
  );
};

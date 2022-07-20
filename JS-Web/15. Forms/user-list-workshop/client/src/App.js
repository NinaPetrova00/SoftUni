import './App.css';

import { Footer } from "./components/common/Footer";
import { Header } from "./components/common/Header";
import { Search } from './components/search/Search';
import { UserTable } from './components/userTable/UserTable';

function App() {
  return (
    <div>
      {/* <!-- Header component --> */}
      <Header />

      {/* <!-- Main component  --> */}
      <main className="main">

        {/* <!-- Section component  --> */}
        <section className="card users-container">

          {/* <!-- Search bar component --> */}
          <Search />

          {/* <!-- Table component --> */}
          <UserTable/>
        </section>
      </main>

      {/* <!-- Footer component  --> */}
      <Footer />
    </div>
  );
}

export default App;

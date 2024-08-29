import { Header } from "./components/header";
import { Post } from "./components/post";
import { SideBar } from "./components/side-bar";

export function App() {

  return (
    <div>
      <Header />
      <div className="max-w-6xl my-8 mx-auto py-0 px-4 flex items-start">
        <div className="grid grid-cols-5 gap-8">
          <SideBar className="col-span-2 w-64 bg-fuchsia-600">
          </SideBar>
          <main className="col-span-3">
            <Post author="Italo Rayone" content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatibus architecto eius illum adipisci atque neque in facilis eaque. Veniam similique, facere expedita aspernatur minus repudiandae officiis nulla vero et illo?" />
          </main>
        </div>
      </div>
    </div>
  )
}
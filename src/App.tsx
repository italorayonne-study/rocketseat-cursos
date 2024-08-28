import { Header } from "./components/header";
import { Post } from "./components/post";
import { SideBar } from "./components/side-bar";

export function App() {

  return (
    <>
      <Header />
      <div className="w-full max-w-6xl m-8 py-0 px-4 grid grid-cols-3 gap-2 items-start">
        <SideBar className="col-span-1">
        </SideBar>
        <main className="col-span-2">
          <Post author="Italo Rayone" content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatibus architecto eius illum adipisci atque neque in facilis eaque. Veniam similique, facere expedita aspernatur minus repudiandae officiis nulla vero et illo?" />
        </main>
      </div>

    </>

  )
}


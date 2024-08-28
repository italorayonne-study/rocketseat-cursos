import { Post } from "./Post"

export function App() {

  return (
    <>
      <Post
        author="Italo Rayone"
        content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Minus quas ex dicta, dolore optio iste. Architecto culpa nam voluptatem expedita fugiat pariatur perspiciatis non! Quae ipsum incidunt ratione quo temporibus?"
      />
      <Post
        className={'text-purple-300'}
        author="Mutty Petismow"
        content="Lorem ipsum dolor sit amet consectetur adipisicing elit. Minus quas ex dicta, dolore optio iste. Architecto culpa nam voluptatem expedita fugiat pariatur perspiciatis non! Quae ipsum incidunt ratione quo temporibus?"
      />
    </>
  )
}
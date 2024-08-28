interface PostProps {
    author: string
    content: string
}

export function Post(props: PostProps) {
    return (
        <div className="w-full p-3 flex flex-col">
            <h1 className="text-2xl font-bold mb-3">{props.author}</h1>
            <p className="text-left">{props.content}</p>
        </div>
    )
}
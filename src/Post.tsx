interface ComponentProps {
    author: string
    content: string
    className?: any
}

export function Post(props: ComponentProps) {
    return (
        <div className={`w-full p-3 flex flex-col items-center ${props.className}`}>
            <h1 className="text-2xl font-bold underline text-red-300 mb-3 text-center">{props.author}</h1>
            <p className="w-4/12 text-left">{props.content}</p>
        </div>
    )
}
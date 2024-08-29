import igniteLogo from '../assets/ignite-logo.svg'

export function Header() {
    return (
        <header className="bg-gray-800 h-20 flex justify-center items-center rounded">
            <img src={igniteLogo} alt='logotipo do ignite' className='h-8' />
        </header>
    )
}
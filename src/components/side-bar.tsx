import { cn } from "../lib/utils";
import { BaseComponentAttributes } from "../share/component-base-attributes";

// eslint-disable-next-line @typescript-eslint/no-empty-object-type
export interface SideBarProps extends BaseComponentAttributes {

}


export function SideBar(props: SideBarProps) {
    return (
        <aside className={cn(props.className)}>
            <img src="https://images.unsplash.com/photo-1477346611705-65d1883cee1e?q=50w%3D500to%3Dformat&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" alt="" />

            <div className="">
                <strong>Nome</strong>
                <span>Cargo</span>
            </div>
            <footer>
                <a href="#" target="_blank" rel="noopener noreferrer">Editar seu perfil</a>
            </footer>
        </aside>
    )
}
import { cn } from "../lib/utils";
import { BaseComponentAttributes } from "../share/component-base-attributes";

// eslint-disable-next-line @typescript-eslint/no-empty-object-type
export interface SideBarProps extends BaseComponentAttributes {

}


export function SideBar(props: SideBarProps) {
    return (
        <aside className={cn(props.className)}>
            SideBar
        </aside>
    )
}
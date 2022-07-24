import { Link, NavLink } from 'react-router-dom';
import styles from './Navigation.module.css';

export const Navigation = () => {
    const setNavStyle = ({ isActive }) => {
        return isActive
            ? styles['active-link']
            : undefined;
    };
    return (
        <nav>
            <ul>
                <li><Link to="/">Home</Link></li>
                <li><NavLink className={setNavStyle} to="/about">About</NavLink></li>
                <li><NavLink className={setNavStyle} to="/pricing">Pricing</NavLink></li>
                <li><NavLink className={setNavStyle} to="/pricing/premium">Premium Pricing</NavLink></li>
                <li><NavLink className={setNavStyle} to="/contacts">Contacts</NavLink></li>

                <li>
                    <NavLink
                        to="/starships"
                        // first way
                        // style={(navLinkProps) => {
                        //     return navLinkProps.isActive
                        //         ? { backgroundColor: 'pink' } 
                        //         : undefined
                        // }}

                        // second way
                        // style={({ isActive }) => ({
                        //     backgroundColor: isActive ? 'pink' : 'lightgray'
                        // })}

                        // third way
                        className={setNavStyle}
                    >
                        Starships
                    </NavLink>
                </li>
                <li><NavLink className={setNavStyle} to="/millennium-falcon">Millennium Falcon</NavLink></li>
            </ul>
        </nav>
    );
}
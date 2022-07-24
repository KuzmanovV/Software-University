import { Link } from "react-router-dom";

export default function ThumbImg({ to, src, alt }) {
  return (
    <div className="col-lg-2 col-md-4 col-xs-6">
      <Link to={to} className="d-block h-100">
        <img className="img-fluid img-thumbnail" src={src} alt={alt} />
      </Link>
    </div>
  );
}

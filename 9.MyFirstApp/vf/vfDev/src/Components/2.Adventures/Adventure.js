export default function Adventure({
  img,
  alt,
  title,
  description,
}) {
  return (
    <div className="row">
      <div className="col-md-6">
        <figure className="figure">
          <a target="blank">
          <img
            src={img.url}
            className="figure-img img-fluid"
            alt={alt}
          />
          </a>
        </figure>
      </div>
      <div className="col-md-6">
        <h4>
          {/* <a href="single.html">{title}</a> */}
          <h5>{title}</h5>
          <p>{description}</p>
        </h4>
      </div>
    </div>
  );
}

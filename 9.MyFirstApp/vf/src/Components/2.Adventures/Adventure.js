export default function Adventure({
  src,
  alt,
  title,
  description,
}) {
  return (
    <div className="row">
      <div className="col-md-6">
        <figure className="figure">
          <a href="https://photos.google.com/share/AF1QipMOuggnmwjt7jmhH--oQrF-qIzzGIBL8bxUzy_WO8PIrQ0Jhju__03aj3y_BbGI8Q?pli=1&key=M3hxVlhrSHdrQm9VMl9rS1F3bDFHVk80V080cDFn">
          <img
            src={src}
            className="figure-img img-fluid"
            alt={alt}
          /></a>
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
